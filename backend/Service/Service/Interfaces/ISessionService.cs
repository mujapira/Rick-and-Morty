using System;
using Service.Models;

namespace Service.Service.Interfaces
{
    public interface ISessionService
    {
        Task<SessionModel> CreateSession();
        Task<bool> CheckSessionValidity(Guid sessionId);
        Task<bool> EndSession(Guid sessionId);
        Task<SessionModel> RetrieveSession(Guid sessionId);
    }

}