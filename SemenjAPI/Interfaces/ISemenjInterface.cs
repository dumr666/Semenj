﻿using SemenjAPI.Models;
using SemenjAPI.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Interfaces
{
    // User interface
    public interface IUserService
    {
        Task<User> CreateUser(UserDto userDto);
    }

    public interface IProductService
    {
        Task<Product> CreateProduct(ProductDto productDto, User productSeller);
    }

    public interface ISessionService
    {

    }
}
