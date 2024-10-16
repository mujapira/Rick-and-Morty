﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service.Models;
using Service.Models.AppSettings;
using Service.Models.ExternalApisSettings;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefas.Corp.Context;
using tarefas.Corp.Entities;

namespace Service.Service
{
    public class SessionService : ISessionService
    {
        private readonly CorpContext _corpContext;

        public SessionService(CorpContext corpContext)
        {
            _corpContext = corpContext;
        }

        public async Task<SessionModel> CreateSession()
        {
            var session = new SessionEntity
            {
                CreatedAt = DateTime.UtcNow
            };

            _corpContext.Sessions.Add(session);
            await _corpContext.SaveChangesAsync();

            return new SessionModel { SessionId = session.SessionId };
        }

        public async Task<bool> CheckSessionValidity(Guid sessionId)
        {
            var session = await _corpContext.Sessions.FindAsync(sessionId);
            if (session == null)
                return true;

            return false;
        }

        public async Task<SessionModel> RetrieveSession(Guid sessionId)
        {
            var session = await _corpContext.Sessions.FindAsync(sessionId);
            if (session == null)
                return null;

            return new SessionModel { SessionId = session.SessionId };
        }

        public async Task<bool> EndSession(Guid sessionId)
        {
            var session = await _corpContext.Sessions.FindAsync(sessionId);
            if (session == null)
                return false;

            _corpContext.Sessions.Remove(session);
            await _corpContext.SaveChangesAsync();
            return true;
        }


    }
}