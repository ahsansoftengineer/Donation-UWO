﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Hierarchy
{
    [Route("api/[controller]")]
  [ApiController]
  public class SUController : BaseController<SUController, SU, SUDtoSearch, SUDto, SUDtoCreate>
  {
    public SUController(
      ILogger<SUController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.SUs;

    }
  }
}