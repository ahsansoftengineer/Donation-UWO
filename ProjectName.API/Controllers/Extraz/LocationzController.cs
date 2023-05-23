﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Extraz
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationzController : CommonController<LocationzController, Locationz>
  {
    public LocationzController(
      ILogger<LocationzController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Locationzs;

    }
  }
}