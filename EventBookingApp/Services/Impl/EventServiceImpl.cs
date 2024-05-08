using System;
using System.Collections.Generic;
using System.Linq;
using EventBooking.Models;
using EventBooking.Repositories;
using EventBooking.Exceptions;
using System.Transactions;
using EventBookingApp.Model;
using EventBookingApp.Services;
using EventBookingApp.Data;
using EventBookingApp.Model.Requests;

namespace EventBooking.Services
{
    public class EventServiceImpl : IEventServices
    {
        private readonly List<string> _ticketTypes;
        private readonly List<string> _eventCategory;
        public EventBookingAPIDbContext _eventBookingAPIDbContext;

        public EventServiceImpl(List<string> eventCategory, List<string> ticketTypes, EventBookingAPIDbContext eventRepository)
        {
            _ticketTypes = ticketTypes;
            _eventCategory = eventCategory;
            _eventBookingAPIDbContext = eventRepository;
        }

        public List<string> AllTicketTypes()
        {
            return _ticketTypes;
        }

        public List<string> AllEventCategory()
        {
            return _eventCategory;
        }

        public EventCategoryAndTicketTypes AllTicketsAndCategory()
        {
            return new EventCategoryAndTicketTypes
            {
                EventCategories = _eventCategory,
                TicketTypes = _ticketTypes
            };
        }

        public PublishEventRequest SaveEvent(PublishEventRequest eventRequest)
        {
            var user = (User)SecurityContextHolder.Context.Authentication.Principal;
            var eventEntity = this.EventRequestToEvent(eventDto);
            eventEntity.User = user;

            using (var scope = new TransactionScope())
            {
                var savedEvent = _eventRepository.SaveEvent(eventEntity);
                var ticketsSpecification = eventDto.TicketsInfo.Select(ticketDto => TicketDto2Ticket(ticketDto, savedEvent)).ToList();
                var savedTickets = _ticketRepository.SaveTickets(ticketsSpecification);

                eventDto = EventToEventDto(savedEvent);
                eventDto.TicketsInfo = savedTickets.Select(ticket => Ticket2TicketDto(ticket)).ToList();

                scope.Complete();
            }

            return eventDto;
        }

        // Implement other methods...
    }
}