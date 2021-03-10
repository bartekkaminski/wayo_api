﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wayo_API.Models;

namespace Wayo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        private readonly ILogger<InfoController> _logger;

        // Testowy kontener na analizowaną pozycję
        private WayoPosition testPosition = new WayoPosition();

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
            Console.WriteLine("RUNN");
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(testPosition);
        }

        [HttpGet("/currentPosition")]
        public ActionResult GetCurrentPosition()
        {
            return Ok(testPosition.ServicePositions.Last());
        }

        [HttpPost("/create")]
        public ActionResult<WayoPosition> CreatePosition(WayoPosition position)
        {
            testPosition = position;

            return Ok(testPosition);
        }

        [HttpPut("/update")]
        public ActionResult<UpdateWayoPositionModel> UpdatePosition(UpdateWayoPositionModel update)
        {
            testPosition.ServicePositions.Add(update.CurrentPosition);
            testPosition.RemainningDistance = update.RemainningDistance;
            testPosition.RemainningDuration = update.RemainningDuration;

            return Ok(testPosition);
        }
    }
}