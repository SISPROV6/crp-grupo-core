using GruposDB.Models;
using Microsoft.EntityFrameworkCore;

namespace GruposRN.CrpGrupo
{
    public class CrpGrupo3Rn
    {

        #region Constructor

        public CrpGrupo3Rn(SisErpv6EstagioContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion Constructor

        #region Private

        private readonly SisErpv6EstagioContext _dbContext;

        #endregion Private

        #region Public Methods

        #region GET

        public List<Crpgrupo> List(string pesquisa)
        {
            try
            {
                List<Crpgrupo> records = new List<Crpgrupo>();

                records = _dbContext.Crpgrupos
                    .Where(e => e.Codigo.Contains(pesquisa) || e.Descricao.Contains(pesquisa))
                    .ToList();

                return records;
            }
            catch
            {
                throw;
            }
        }

        #endregion GET

        #region PATCH

        public void UpdateStatus(long id, bool newStatus)
        {
            try
            {
                Crpgrupo? current = _dbContext.Crpgrupos.FirstOrDefault(e => e.Idcrpgrupo == id);

                if (current == null) throw new Exception($"O registro com ID '{id}' não foi encontrado");

                current.IsActive = newStatus;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        #endregion PATCH

        #endregion Public Methods

    }
}
