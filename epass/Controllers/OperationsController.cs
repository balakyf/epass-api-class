﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using epass.modeles;
using epass.models;

namespace epass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly ModelsContext _context;

        public OperationsController(ModelsContext context)
        {
            _context = context;
        }

        // GET: api/Operations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Operation>>> GetOperation()
        {
            return await _context.Operation.ToListAsync();
        }

        // GET: api/Operations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Operation>> GetOperation(Guid id)
        {
            var operation = await _context.Operation.FindAsync(id);

            if (operation == null)
            {
                return NotFound();
            }

            return operation;
        }

        // PUT: api/Operations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperation(Guid id, Operation operation)
        {
            if (id != operation.Id)
            {
                return BadRequest();
            }

            _context.Entry(operation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Operations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Operation>> PostOperation(Operation operation)
        {
            _context.Operation.Add(operation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperation", new { id = operation.Id }, operation);
        }

        // DELETE: api/Operations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Operation>> DeleteOperation(Guid id)
        {
            var operation = await _context.Operation.FindAsync(id);
            if (operation == null)
            {
                return NotFound();
            }

            _context.Operation.Remove(operation);
            await _context.SaveChangesAsync();

            return operation;
        }

        private bool OperationExists(Guid id)
        {
            return _context.Operation.Any(e => e.Id == id);
        }
    }
}
