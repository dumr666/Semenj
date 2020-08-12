using SemenjAPI.Interfaces;
using SemenjAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Services
{
    public class SessionService : ISessionService
    {
        private readonly SemenjAPIContext semenjAPIContext;
        public SessionService(SemenjAPIContext semenjAPIContext)
        {
            this.semenjAPIContext = semenjAPIContext;
        }

        // Task za login
        public async Task<Session> CreateSession(User loginUser)
        {
            var sessionToCreate = new Session(
                userId: loginUser.Id,
                user: loginUser
                );

            var result = await semenjAPIContext.Sessions.AddAsync(sessionToCreate);
            await semenjAPIContext.SaveChangesAsync();
            return sessionToCreate;
        }
    }
}
