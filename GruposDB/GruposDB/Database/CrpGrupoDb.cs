using GruposDB.Models;
using Microsoft.EntityFrameworkCore;

namespace GruposDB.Database
{
    public class CrpGrupoDb
    {

        #region Constructor

        public CrpGrupoDb(SisErpv6EstagioContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion Constructor

        #region Private

        private readonly SisErpv6EstagioContext _dbContext;

        #endregion Private

        #region Public Methods

        #region CREATE

        public long Create(Crpgrupo record)
        {
            try
            {
                if (record == null) throw new Exception("A estrutura está inválida.");

                _dbContext.Crpgrupos.Add(record);
                _dbContext.SaveChanges();

                Crpgrupo? newRecord = _dbContext.Crpgrupos.LastOrDefault();
                if (newRecord == null) throw new Exception("Não foi possível encontrar o registro recém criado.");

                return newRecord.Idcrpgrupo;
            }
            catch
            {
                throw;
            }
        }

        #endregion CREATE

        #region READ

        public Crpgrupo Get(long id)
        {
            try
            {
                //Crpgrupo? record = _dbContext.Crpgrupos.FirstOrDefault(e => e.Idcrpgrupo == id);

                //if (record == null) throw new Exception($"O registro com ID '{id}' não foi encontrado.");
                //return record;

                // Mais semelhnate à forma que usamos atualmente com o comando
                Crpgrupo? record = _dbContext.Crpgrupos.FromSql($@"
                    SELECT  TENANT_ID,
                            IDCRPGRUPO,
                            CODIGO,
                            DESCRICAO,
                            ISGRUPOFINAL,
                            NUMERONIVEL,
                            IS_ACTIVE,
                            IS_CATALOGO

                    FROM    CRPGRUPO
                    WHERE   IDCRPGRUPO = {id}
                ").FirstOrDefault();

                if (record == null) throw new Exception($"O registro com ID '{id}' não foi encontrado.");
                return record;
            }
            catch
            {
                throw;
            }
        }

        #endregion READ

        #region UPDATE

        public void Update(Crpgrupo record)
        {
            try
            {
                Crpgrupo? current = _dbContext.Crpgrupos.FirstOrDefault(e => e.Idcrpgrupo == record.Idcrpgrupo);

                if (current != null)
                {
                    current.TenantId = record.TenantId;
                    current.Idcrpgrupo = record.Idcrpgrupo;
                    current.Codigo = record.Codigo;
                    current.Descricao = record.Descricao;
                    current.Isgrupofinal = record.Isgrupofinal;
                    current.Numeronivel = record.Numeronivel;
                    current.IsActive = record.IsActive;
                    current.IsCatalogo = record.IsCatalogo;

                    _dbContext.SaveChanges(); // EF Core detects changes and generates an UPDATE statement
                }
                else throw new Exception($"O registro com ID '{record.Idcrpgrupo}' não foi encontrado");
            }
            catch
            {
                throw;
            }
        }

        #endregion UPDATE

        #region DELETE

        public void Delete(long id)
        {
            try
            {
                //if (id == 0) throw new Exception("O ID está inválido.");

                //Crpgrupo? record = _dbContext.Crpgrupos.FirstOrDefault(e => e.Idcrpgrupo == id);
                //if (record == null) throw new Exception("Não foi possível encontrar o registro a ser excluído.");

                //_dbContext.Crpgrupos.Remove(record);
                //_dbContext.SaveChanges();

                // Mais semelhnate à forma que usamos atualmente com o comando
                _dbContext.Database.ExecuteSql($@"
                    DELETE  CRPGRUPO
                    WHERE   IDCRPGRUPO = {id}
                ");
            }
            catch
            {
                throw;
            }
        }

        #endregion DELETE

        #endregion Public Methods

    }
}
