﻿using Microsoft.AspNetCore.Mvc;
using MP.Api.DotNet6.Application.DTOs;
using MP.Api.DotNet6.Application.Services;
using MP.Api.DotNet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.Validations;

namespace MP.ApiDotNet6.Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase {

        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService) {
            _purchaseService = purchaseService;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] PurchaseDTO purchaseDTO) {

            try {
                var result = await _purchaseService.CreateAsync(purchaseDTO);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }
            catch (DomainValidationException ex) {
                var result = ResultService.Fail(ex.Message);
                return BadRequest(result);
            }

        }
    }
}
