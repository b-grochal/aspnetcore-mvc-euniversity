﻿using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<IdentityAdmin> _userManager;
        private readonly IMapper _mapper;

        public AdminRepository(UserManager<IdentityAdmin> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<Admin> AddAsync(Admin entity)
        {
            var identityAdmin = _mapper.Map<IdentityAdmin>(entity);
            var identityResult = await _userManager.CreateAsync(identityAdmin, "P@ssword");
            return entity;
        }

        public Task DeleteAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Admin>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}