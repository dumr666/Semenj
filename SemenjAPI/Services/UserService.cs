using Microsoft.EntityFrameworkCore;
using SemenjAPI.Interfaces;
using SemenjAPI.Models;
using SemenjAPI.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Services
{
    public class UserService : IUserService
    {
        private readonly SemenjAPIContext semenjAPIContext;

        public UserService(SemenjAPIContext semenjAPIContext)
        {
            this.semenjAPIContext = semenjAPIContext;
        }

        // Task za dodajanje novega uporabnika
        public async Task<User> CreateUser(UserDto userDto)
        {
            var userExists = await semenjAPIContext
                .Users
                .Where(x => x.Username == userDto.Username)
                .FirstOrDefaultAsync();

            if(userExists != null)
            {
                throw new InvalidOperationException();
            }

            var userToCreate = new User(
                name: userDto.Name,
                surname: userDto.Surname,
                username: userDto.Username,
                password: userDto.Password,
                emailAddress: userDto.EmailAddress,
                phoneNumber: userDto.PhoneNumber,
                mobileNumber: userDto.MobileNumber,
                address: userDto.Address,
                postCode: userDto.PostCode,
                city: userDto.City,
                birthDate: userDto.BirthDate
                );

            var result = await semenjAPIContext.Users.AddAsync(userToCreate);
            await semenjAPIContext.SaveChangesAsync();
            return userToCreate;
        }
    }
}
