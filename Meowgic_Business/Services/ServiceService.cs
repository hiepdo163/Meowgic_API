﻿using Meowgic.Business.Interface;
using Meowgic.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Business.Services
{
    public class ServiceService(IUnitOfWork unitOfWork) : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
    }
}