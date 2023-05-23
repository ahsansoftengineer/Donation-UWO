﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Donation;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Donation
{
  [Route("api/[controller]")]
  [ApiController]
  public class DonationTypeController : CharlieController<DonationTypeController, DonationType, DonationTypeDtoSearch, DonationTypeDto, DonationTypeDtoCreate>
  {
    public DonationTypeController(
      ILogger<DonationTypeController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonationTypes;

    }
  }
}