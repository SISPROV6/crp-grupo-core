using Microsoft.AspNetCore.Mvc;
using GruposDB.Models;
using GruposRN.CrpGrupo;
using GruposDB.Database;

namespace GruposWS.Controllers
{
    [ApiController]
    [Route("api/grupos")]
    public class CrpGruposController : Controller
    {

        #region Constructor

        public CrpGruposController(SisErpv6EstagioContext dbContext)
        {
            _crpGrupoRn = new CrpGrupo3Rn(dbContext);
            _crpGrupoDb = new CrpGrupoDb(dbContext);
        }

        #endregion Constructor

        #region Private

        private CrpGrupo3Rn _crpGrupoRn;
        private CrpGrupoDb _crpGrupoDb;

        #endregion Private

        #region Public Methods

        #region GET

        [HttpGet]
        public IActionResult List(string pesquisa = "")
        {
            try
            {
                var records = _crpGrupoRn.List(pesquisa);
                return Ok(records);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            try
            {
                Crpgrupo record = _crpGrupoDb.Get(id);
                return Ok(record);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion GET

        #region POST

        [HttpPost]
        public IActionResult Create(Crpgrupo record)
        {
            try
            {
                _crpGrupoDb.Create(record);

                return Created("api/grupos/", record);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion POST

        #region PUT

        [HttpPut]
        public IActionResult Update(Crpgrupo record)
        {
            try
            {
                _crpGrupoDb.Update(record);

                return Ok("Registro alterado com sucesso.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion PUT

        #region PATCH

        [HttpPatch]
        public IActionResult UpdateStatus(long id, bool newStatus)
        {
            try
            {
                _crpGrupoRn.UpdateStatus(id, newStatus);

                return Ok("Status alterado com sucesso.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion PATCH

        #region DELETE

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            try
            {
                _crpGrupoDb.Delete(id);

                return Ok("Registro excluído com sucesso.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion DELETE

        #endregion Public Methods

    }
}
