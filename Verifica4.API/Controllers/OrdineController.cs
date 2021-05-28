using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verifica4.Core2.BusinessLayer;
using Verifica4.Core2.Interfaces;
using Verifica4.Core2.Model;
using Verifica4.EntityFrk2.Repositories;

namespace Verifica4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        private OrdiniBL layer;

        public OrdineController()
        {
            IRepository<Cliente> clienteRepo = new EFClienteRepository();
            IRepository<Ordine> ordineRepo = new EFOrdineRepository();
            layer = new OrdiniBL(clienteRepo, ordineRepo);
        }

        [HttpGet]
        public ActionResult<Ordine> Get()
        {
            var result = layer.FetchOrdini();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Id.");    // HTTP 400

            var ordine = layer.FetchOrdineById(id);

            if (ordine == null)
                return NotFound();      //404

            return Ok(ordine);
        }

        [HttpPut("{id}")]
        public ActionResult PutOrder(int id, [FromBody] Ordine editedOrdine)
        {
            if (editedOrdine == null)
                return BadRequest("Invalid Order data.");

            if (id != editedOrdine.Id)
                return BadRequest("Order Ids don't match.");

            layer.EditOrdine(editedOrdine);

            return Ok();      // HTTP 200
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Order Id.");  //HTTP 400

            var orderToBeDeleted = layer.FetchOrdineById(id);

            if (orderToBeDeleted != null)
                layer.DeleteOrdine(orderToBeDeleted);

            return Ok();    // HTTP 200
        }

        [HttpPost]
        public ActionResult PostNewOrder([FromBody] Ordine newOrdine) 
        {
            if (newOrdine == null)
                return BadRequest("Invalid Order data.");

            this.layer.CreateOrdine(newOrdine);
            //this.layer.SaveChanges();

            return Created($"/ordini/{newOrdine.Id}", newOrdine);  // HTTP 201
        }
    }
}
