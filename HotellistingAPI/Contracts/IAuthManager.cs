﻿using HotellistingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotellistingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
