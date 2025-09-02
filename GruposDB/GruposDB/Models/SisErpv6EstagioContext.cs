using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GruposDB.Models;

public partial class SisErpv6EstagioContext : DbContext
{
    public SisErpv6EstagioContext()
    {
    }

    public SisErpv6EstagioContext(DbContextOptions<SisErpv6EstagioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BiblAutor> BiblAutors { get; set; }

    public virtual DbSet<BiblCliente> BiblClientes { get; set; }

    public virtual DbSet<BiblEditora> BiblEditoras { get; set; }

    public virtual DbSet<BiblEmprestimo> BiblEmprestimos { get; set; }

    public virtual DbSet<BiblEmprestimoLivro> BiblEmprestimoLivros { get; set; }

    public virtual DbSet<BiblEndereco> BiblEnderecos { get; set; }

    public virtual DbSet<BiblInCategorium> BiblInCategoria { get; set; }

    public virtual DbSet<BiblInTipoCliente> BiblInTipoClientes { get; set; }

    public virtual DbSet<BiblInTipoEndereco> BiblInTipoEnderecos { get; set; }

    public virtual DbSet<BiblLivro> BiblLivros { get; set; }

    public virtual DbSet<Crpgrupo> Crpgrupos { get; set; }

    public virtual DbSet<EstAnexoLancamento> EstAnexoLancamentos { get; set; }

    public virtual DbSet<EstCategoriaproduto> EstCategoriaprodutos { get; set; }

    public virtual DbSet<EstContato> EstContatos { get; set; }

    public virtual DbSet<EstEndereco> EstEnderecos { get; set; }

    public virtual DbSet<EstHistoricoLancamento> EstHistoricoLancamentos { get; set; }

    public virtual DbSet<EstHistoricoPreco> EstHistoricoPrecos { get; set; }

    public virtual DbSet<EstLancamento> EstLancamentos { get; set; }

    public virtual DbSet<EstLogAuditorium> EstLogAuditoria { get; set; }

    public virtual DbSet<EstPapel> EstPapels { get; set; }

    public virtual DbSet<EstPessoa> EstPessoas { get; set; }

    public virtual DbSet<EstProduto> EstProdutos { get; set; }

    public virtual DbSet<EstProdutoLancto> EstProdutoLanctos { get; set; }

    public virtual DbSet<EstSituacaolancamento> EstSituacaolancamentos { get; set; }

    public virtual DbSet<EstTipoendereco> EstTipoenderecos { get; set; }

    public virtual DbSet<EstTipolancamento> EstTipolancamentos { get; set; }

    public virtual DbSet<EstTipopessoa> EstTipopessoas { get; set; }

    public virtual DbSet<EstUf> EstUfs { get; set; }

    public virtual DbSet<InfraLogRecupSenha> InfraLogRecupSenhas { get; set; }

    public virtual DbSet<Infraauthentication> Infraauthentications { get; set; }

    public virtual DbSet<Infraemailcfg> Infraemailcfgs { get; set; }

    public virtual DbSet<Infraempresa> Infraempresas { get; set; }

    public virtual DbSet<Infraestabelecimento> Infraestabelecimentos { get; set; }

    public virtual DbSet<Infraestabfavorito> Infraestabfavoritos { get; set; }

    public virtual DbSet<Infragrupo> Infragrupos { get; set; }

    public virtual DbSet<Infrain2fatype> Infrain2fatypes { get; set; }

    public virtual DbSet<Infrainauthtype> Infrainauthtypes { get; set; }

    public virtual DbSet<Inframnumenu> Inframnumenus { get; set; }

    public virtual DbSet<Inframnumenuusuario> Inframnumenuusuarios { get; set; }

    public virtual DbSet<Infrasegconfig> Infrasegconfigs { get; set; }

    public virtual DbSet<Infrausuario> Infrausuarios { get; set; }

    public virtual DbSet<InfrausuarioImg> InfrausuarioImgs { get; set; }

    public virtual DbSet<Infrausuariolog1> Infrausuariolog1s { get; set; }

    public virtual DbSet<Infrausuariosenhaslog> Infrausuariosenhaslogs { get; set; }

    public virtual DbSet<LocAluguel> LocAluguels { get; set; }

    public virtual DbSet<LocCliente> LocClientes { get; set; }

    public virtual DbSet<LocEnderecoCliente> LocEnderecoClientes { get; set; }

    public virtual DbSet<LocFuncionario> LocFuncionarios { get; set; }

    public virtual DbSet<LocMarca> LocMarcas { get; set; }

    public virtual DbSet<LocTipoVeiculo> LocTipoVeiculos { get; set; }

    public virtual DbSet<LocVeiculo> LocVeiculos { get; set; }

    public virtual DbSet<OssysTenant> OssysTenants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BiblAutor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblAuto__3214EC072F19D9F0");

            entity.ToTable("BiblAutor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TxNome)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.BiblEndereco).WithMany(p => p.BiblAutors)
                .HasForeignKey(d => d.BiblEnderecoId)
                .HasConstraintName("FK_BiblAutor_BiblEndereco");
        });

        modelBuilder.Entity<BiblCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblClie__3214EC07395AA4F3");

            entity.ToTable("BiblCliente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TxCpf)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("TxCPF");
            entity.Property(e => e.TxNome)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.BiblEndereco).WithMany(p => p.BiblClientes)
                .HasForeignKey(d => d.BiblEnderecoId)
                .HasConstraintName("FK_BiblCliente_BiblEndereco");

            entity.HasOne(d => d.BiblInTipoCliente).WithMany(p => p.BiblClientes)
                .HasForeignKey(d => d.BiblInTipoClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblCliente_TipoCliente");
        });

        modelBuilder.Entity<BiblEditora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblEdit__3214EC0723DAB64C");

            entity.ToTable("BiblEditora");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TxNome)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BiblEmprestimo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblEmpr__3214EC0799B35C32");

            entity.ToTable("BiblEmprestimo");

            entity.HasIndex(e => e.TxProtocolo, "UQ_BiblEmprestimo_TxProtocolo").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TxProtocolo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorMulta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BiblCliente).WithMany(p => p.BiblEmprestimos)
                .HasForeignKey(d => d.BiblClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblEmprestimo_Cliente");
        });

        modelBuilder.Entity<BiblEmprestimoLivro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblEmpr__3214EC0751C7D70B");

            entity.ToTable("BiblEmprestimoLivro");

            entity.HasIndex(e => new { e.BiblEmprestimoId, e.BiblLivroId }, "UQ_BiblEmprestimoLivro_UniqueItem").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BiblEmprestimo).WithMany(p => p.BiblEmprestimoLivros)
                .HasForeignKey(d => d.BiblEmprestimoId)
                .HasConstraintName("FK_BiblEmprestimoLivro_Emprestimo");

            entity.HasOne(d => d.BiblLivro).WithMany(p => p.BiblEmprestimoLivros)
                .HasForeignKey(d => d.BiblLivroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblEmprestimoLivro_Livro");
        });

        modelBuilder.Entity<BiblEndereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblEnde__3214EC07E764D7A8");

            entity.ToTable("BiblEndereco");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Bairro).HasMaxLength(100);
            entity.Property(e => e.Cidade).HasMaxLength(100);
            entity.Property(e => e.Nro).HasMaxLength(20);
            entity.Property(e => e.Regiao).HasMaxLength(50);
            entity.Property(e => e.Rua).HasMaxLength(200);
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UF");

            entity.HasOne(d => d.BiblInTipoEnderecoNavigation).WithMany(p => p.BiblEnderecos)
                .HasForeignKey(d => d.BiblInTipoEndereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblEndereco_BiblInTipoEndereco");
        });

        modelBuilder.Entity<BiblInCategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblInCa__3214EC0765A21970");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("Is_Active");
            entity.Property(e => e.Label)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BiblInTipoCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblInTi__3214EC07D8BAD340");

            entity.ToTable("BiblInTipoCliente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("Is_Active");
            entity.Property(e => e.Label)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BiblInTipoEndereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblInTi__3214EC07CC27ABE2");

            entity.ToTable("BiblInTipoEndereco");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.Label).HasMaxLength(100);
        });

        modelBuilder.Entity<BiblLivro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BiblLivr__3214EC0772BC73FB");

            entity.ToTable("BiblLivro");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.LocalPublicacao)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.TxTitulo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.BiblAutor).WithMany(p => p.BiblLivros)
                .HasForeignKey(d => d.BiblAutorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblLivro_Autor");

            entity.HasOne(d => d.BiblEditora).WithMany(p => p.BiblLivros)
                .HasForeignKey(d => d.BiblEditoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblLivro_Editora");

            entity.HasOne(d => d.BiblInCategoria).WithMany(p => p.BiblLivros)
                .HasForeignKey(d => d.BiblInCategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiblLivro_Categoria");
        });

        modelBuilder.Entity<Crpgrupo>(entity =>
        {
            
            entity.ToTable("CRPGRUPO");

            // Informa que esta coluna é a chave primária da tabela
            entity.HasKey(p => p.Idcrpgrupo);

            // Adicionada para auto incrementar o ID a cada criação
            entity.Property(e => e.Idcrpgrupo)
                .ValueGeneratedOnAdd();


            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("DESCRICAO");
            entity.Property(e => e.Idcrpgrupo)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDCRPGRUPO");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsCatalogo).HasColumnName("IS_CATALOGO");
            entity.Property(e => e.Isgrupofinal).HasColumnName("ISGRUPOFINAL");
            entity.Property(e => e.Numeronivel).HasColumnName("NUMERONIVEL");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<EstAnexoLancamento>(entity =>
        {
            entity.HasKey(e => e.IdAnexo).HasName("PK__EST_ANEX__06F01DAF4AB42D6F");

            entity.ToTable("EST_ANEXO_LANCAMENTO");

            entity.Property(e => e.IdAnexo).HasColumnName("ID_ANEXO");
            entity.Property(e => e.Arquivo).HasColumnName("ARQUIVO");
            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.DtCriacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_CRIACAO");
            entity.Property(e => e.IsNfe).HasColumnName("IS_NFE");
            entity.Property(e => e.Lancamentoid).HasColumnName("LANCAMENTOID");
            entity.Property(e => e.Nomearquivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMEARQUIVO");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Usuarioid)
                .HasMaxLength(36)
                .HasColumnName("USUARIOID");

            entity.HasOne(d => d.Lancamento).WithMany(p => p.EstAnexoLancamentos)
                .HasForeignKey(d => d.Lancamentoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_ANEXO__LANCA__42E1EEFE");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstAnexoLancamentos)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_ANEXO__TENAN__41EDCAC5");

            entity.HasOne(d => d.Usuario).WithMany(p => p.EstAnexoLancamentos)
                .HasForeignKey(d => d.Usuarioid)
                .HasConstraintName("FK__EST_ANEXO__USUAR__44CA3770");
        });

        modelBuilder.Entity<EstCategoriaproduto>(entity =>
        {
            entity.HasKey(e => e.CdCategoriaproduto).HasName("PK__EST_CATE__FF44A5A6E1DAB92B");

            entity.ToTable("EST_CATEGORIAPRODUTO");

            entity.Property(e => e.CdCategoriaproduto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CD_CATEGORIAPRODUTO");
            entity.Property(e => e.TxNome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOME");
        });

        modelBuilder.Entity<EstContato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EST_CONT__3214EC2783C24940");

            entity.ToTable("EST_CONTATO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PessoaId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PESSOA_ID");
            entity.Property(e => e.TxApelidocontato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_APELIDOCONTATO");
            entity.Property(e => e.TxCelular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TX_CELULAR");
            entity.Property(e => e.TxEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TX_EMAIL");
            entity.Property(e => e.TxRamal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TX_RAMAL");
            entity.Property(e => e.TxTelefonefixo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TX_TELEFONEFIXO");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.EstContatos)
                .HasForeignKey(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_CONTA__PESSO__114A936A");
        });

        modelBuilder.Entity<EstEndereco>(entity =>
        {
            entity.HasKey(e => e.IdEndereco).HasName("PK__EST_ENDE__0657EF8454AAED4D");

            entity.ToTable("EST_ENDERECO");

            entity.Property(e => e.IdEndereco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("ID_ENDERECO");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAIRRO");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIDADE");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLEMENTO");
            entity.Property(e => e.IsPrincipal).HasColumnName("IS_PRINCIPAL");
            entity.Property(e => e.Logradouro)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LOGRADOURO");
            entity.Property(e => e.Numero).HasColumnName("NUMERO");
            entity.Property(e => e.PessoaId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PESSOA_ID");
            entity.Property(e => e.TipoenderecoCd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TIPOENDERECO_CD");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UF");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.EstEnderecos)
                .HasForeignKey(d => d.PessoaId)
                .HasConstraintName("FK__EST_ENDER__PESSO__282DF8C2");

            entity.HasOne(d => d.TipoenderecoCdNavigation).WithMany(p => p.EstEnderecos)
                .HasForeignKey(d => d.TipoenderecoCd)
                .HasConstraintName("FK__EST_ENDER__TIPOE__2A164134");

            entity.HasOne(d => d.UfNavigation).WithMany(p => p.EstEnderecos)
                .HasForeignKey(d => d.Uf)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_ENDERECO__UF__29221CFB");
        });

        modelBuilder.Entity<EstHistoricoLancamento>(entity =>
        {
            entity.HasKey(e => e.IdHistorico).HasName("PK__EST_HIST__9679E8E0D43E9AB6");

            entity.ToTable("EST_HISTORICO_LANCAMENTO");

            entity.Property(e => e.IdHistorico).HasColumnName("ID_HISTORICO");
            entity.Property(e => e.DtEnvio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_ENVIO");
            entity.Property(e => e.IsOrigemSistema).HasColumnName("IS_ORIGEM_SISTEMA");
            entity.Property(e => e.Lancamentoid).HasColumnName("LANCAMENTOID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TxAcaoExecutada)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TX_ACAO_EXECUTADA");
            entity.Property(e => e.TxComentario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TX_COMENTARIO");
            entity.Property(e => e.Usuarioid)
                .HasMaxLength(36)
                .HasColumnName("USUARIOID");

            entity.HasOne(d => d.Lancamento).WithMany(p => p.EstHistoricoLancamentos)
                .HasForeignKey(d => d.Lancamentoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_HISTO__LANCA__498EEC8D");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstHistoricoLancamentos)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_HISTO__TENAN__489AC854");

            entity.HasOne(d => d.Usuario).WithMany(p => p.EstHistoricoLancamentos)
                .HasForeignKey(d => d.Usuarioid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_HISTO__USUAR__4B7734FF");
        });

        modelBuilder.Entity<EstHistoricoPreco>(entity =>
        {
            entity.HasKey(e => e.IdHistorico).HasName("PK__EST_HIST__9679E8E090D6B5E4");

            entity.ToTable("EST_HISTORICO_PRECO");

            entity.Property(e => e.IdHistorico).HasColumnName("ID_HISTORICO");
            entity.Property(e => e.DtVigencia)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_VIGENCIA");
            entity.Property(e => e.ProdutoId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PRODUTO_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.VlNovopreco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_NOVOPRECO");
            entity.Property(e => e.VlPrecoanterior)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_PRECOANTERIOR");

            entity.HasOne(d => d.Produto).WithMany(p => p.EstHistoricoPrecos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_HISTO__PRODU__3D2915A8");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstHistoricoPrecos)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_HISTO__TENAN__3C34F16F");
        });

        modelBuilder.Entity<EstLancamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EST_LANC__3214EC27ABC8170B");

            entity.ToTable("EST_LANCAMENTO");

            entity.HasIndex(e => e.TxCodigobarras, "UQ__EST_LANC__FB0D33B54737E522").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DtLancamento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_LANCAMENTO");
            entity.Property(e => e.DtPagamento)
                .HasColumnType("datetime")
                .HasColumnName("DT_PAGAMENTO");
            entity.Property(e => e.DtVencimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.Estabelecimentoid)
                .HasMaxLength(36)
                .HasColumnName("ESTABELECIMENTOID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.PessoaDestinatarioId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PESSOA_DESTINATARIO_ID");
            entity.Property(e => e.PessoaId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PESSOA_ID");
            entity.Property(e => e.PessoaRemetenteId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PESSOA_REMETENTE_ID");
            entity.Property(e => e.SituacaoCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SITUACAO_CD");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TipolancamentoCd)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TIPOLANCAMENTO_CD");
            entity.Property(e => e.TxCodigobarras)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("TX_CODIGOBARRAS");
            entity.Property(e => e.TxDescricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TX_DESCRICAO");
            entity.Property(e => e.VlDesconto)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlImposto)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_IMPOSTO");
            entity.Property(e => e.VlLancamento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_LANCAMENTO");

            entity.HasOne(d => d.Estabelecimento).WithMany(p => p.EstLancamentos)
                .HasForeignKey(d => d.Estabelecimentoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__ESTAB__2180FB33");

            entity.HasOne(d => d.PessoaDestinatario).WithMany(p => p.EstLancamentoPessoaDestinatarios)
                .HasForeignKey(d => d.PessoaDestinatarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__PESSO__25518C17");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.EstLancamentoPessoas)
                .HasForeignKey(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__PESSO__1DB06A4F");

            entity.HasOne(d => d.PessoaRemetente).WithMany(p => p.EstLancamentoPessoaRemetentes)
                .HasForeignKey(d => d.PessoaRemetenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__PESSO__245D67DE");

            entity.HasOne(d => d.SituacaoCdNavigation).WithMany(p => p.EstLancamentos)
                .HasForeignKey(d => d.SituacaoCd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__SITUA__1F98B2C1");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstLancamentos)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__TENAN__1BC821DD");

            entity.HasOne(d => d.TipolancamentoCdNavigation).WithMany(p => p.EstLancamentos)
                .HasForeignKey(d => d.TipolancamentoCd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LANCA__TIPOL__1CBC4616");
        });

        modelBuilder.Entity<EstLogAuditorium>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK__EST_LOG___2DBE379D35011D99");

            entity.ToTable("EST_LOG_AUDITORIA");

            entity.Property(e => e.IdLog).HasColumnName("ID_LOG");
            entity.Property(e => e.DtAcaorealizada)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_ACAOREALIZADA");
            entity.Property(e => e.InfrausuarioId)
                .HasMaxLength(36)
                .HasColumnName("INFRAUSUARIO_ID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TxAcaorealizada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_ACAOREALIZADA");
            entity.Property(e => e.TxDescricaodetalhada)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TX_DESCRICAODETALHADA");
            entity.Property(e => e.TxTabela)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_TABELA");

            entity.HasOne(d => d.Infrausuario).WithMany(p => p.EstLogAuditoria)
                .HasForeignKey(d => d.InfrausuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LOG_A__INFRA__395884C4");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstLogAuditoria)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_LOG_A__TENAN__37703C52");
        });

        modelBuilder.Entity<EstPapel>(entity =>
        {
            entity.HasKey(e => e.CdPapel).HasName("PK__EST_PAPE__53700027A72C2D6F");

            entity.ToTable("EST_PAPEL");

            entity.Property(e => e.CdPapel)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CD_PAPEL");
            entity.Property(e => e.TxNome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOME");
        });

        modelBuilder.Entity<EstPessoa>(entity =>
        {
            entity.HasKey(e => e.IdPessoa).HasName("PK__EST_PESS__7ACBCDD94AAEA89D");

            entity.ToTable("EST_PESSOA");

            entity.Property(e => e.IdPessoa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.DtCriacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_CRIACAO");
            entity.Property(e => e.DtFundacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_FUNDACAO");
            entity.Property(e => e.DtIniciovinculo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_INICIOVINCULO");
            entity.Property(e => e.DtNascimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_NASCIMENTO");
            entity.Property(e => e.DtUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ULTIMAALTERACAO");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsEstrangeiro).HasColumnName("IS_ESTRANGEIRO");
            entity.Property(e => e.PapelCd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAPEL_CD");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TipopessoaCd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPOPESSOA_CD");
            entity.Property(e => e.TxDocumento)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("TX_DOCUMENTO");
            entity.Property(e => e.TxNomepessoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOMEPESSOA");

            entity.HasOne(d => d.PapelCdNavigation).WithMany(p => p.EstPessoas)
                .HasForeignKey(d => d.PapelCd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PESSO__PAPEL__0B91BA14");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstPessoas)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PESSO__TENAN__09A971A2");

            entity.HasOne(d => d.TipopessoaCdNavigation).WithMany(p => p.EstPessoas)
                .HasForeignKey(d => d.TipopessoaCd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PESSO__TIPOP__0A9D95DB");
        });

        modelBuilder.Entity<EstProduto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__EST_PROD__69B28A5210FA5879");

            entity.ToTable("EST_PRODUTO");

            entity.Property(e => e.IdProduto)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("ID_PRODUTO");
            entity.Property(e => e.CategoriaCd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CATEGORIA_CD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.QtAtual)
                .HasDefaultValue(0L)
                .HasColumnName("QT_ATUAL");
            entity.Property(e => e.QtMinima)
                .HasDefaultValue(0L)
                .HasColumnName("QT_MINIMA");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TxDescricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TX_DESCRICAO");
            entity.Property(e => e.TxNome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOME");
            entity.Property(e => e.VlPrecoRecomendado)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_PRECO_RECOMENDADO");

            entity.HasOne(d => d.CategoriaCdNavigation).WithMany(p => p.EstProdutos)
                .HasForeignKey(d => d.CategoriaCd)
                .HasConstraintName("FK__EST_PRODU__CATEG__151B244E");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EstProdutos)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PRODU__TENAN__14270015");
        });

        modelBuilder.Entity<EstProdutoLancto>(entity =>
        {
            entity.HasKey(e => e.IdProdutolancamento).HasName("PK__EST_PROD__FA0992CCE2AAE36A");

            entity.ToTable("EST_PRODUTO_LANCTO");

            entity.Property(e => e.IdProdutolancamento).HasColumnName("ID_PRODUTOLANCAMENTO");
            entity.Property(e => e.DtPedido)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT_PEDIDO");
            entity.Property(e => e.LancamentoId).HasColumnName("LANCAMENTO_ID");
            entity.Property(e => e.ProdutoId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("PRODUTO_ID");
            entity.Property(e => e.QtProduto).HasColumnName("QT_PRODUTO");
            entity.Property(e => e.VlTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VL_TOTAL");

            entity.HasOne(d => d.Lancamento).WithMany(p => p.EstProdutoLanctos)
                .HasForeignKey(d => d.LancamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PRODU__LANCA__11158940");

            entity.HasOne(d => d.Produto).WithMany(p => p.EstProdutoLanctos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EST_PRODU__PRODU__0F2D40CE");
        });

        modelBuilder.Entity<EstSituacaolancamento>(entity =>
        {
            entity.HasKey(e => e.CdSituacaolancamento).HasName("PK__EST_SITU__D150210CF6D3D70B");

            entity.ToTable("EST_SITUACAOLANCAMENTO");

            entity.Property(e => e.CdSituacaolancamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_SITUACAOLANCAMENTO");
            entity.Property(e => e.TxNome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOME");
        });

        modelBuilder.Entity<EstTipoendereco>(entity =>
        {
            entity.HasKey(e => e.CdTipoendereco).HasName("PK__EST_TIPO__1C93A3B42DDEF29A");

            entity.ToTable("EST_TIPOENDERECO");

            entity.Property(e => e.CdTipoendereco)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CD_TIPOENDERECO");
            entity.Property(e => e.TxTipoendereco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_TIPOENDERECO");
        });

        modelBuilder.Entity<EstTipolancamento>(entity =>
        {
            entity.HasKey(e => e.CdTipo).HasName("PK__EST_TIPO__142E5898AEF97E1D");

            entity.ToTable("EST_TIPOLANCAMENTO");

            entity.Property(e => e.CdTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CD_TIPO");
            entity.Property(e => e.TxTipolancamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TX_TIPOLANCAMENTO");
        });

        modelBuilder.Entity<EstTipopessoa>(entity =>
        {
            entity.HasKey(e => e.CdTipopessoa).HasName("PK__EST_TIPO__331BFF8514BE8112");

            entity.ToTable("EST_TIPOPESSOA");

            entity.Property(e => e.CdTipopessoa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CD_TIPOPESSOA");
            entity.Property(e => e.TxTipopessoa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TX_TIPOPESSOA");
        });

        modelBuilder.Entity<EstUf>(entity =>
        {
            entity.HasKey(e => e.CdUf).HasName("PK__EST_UF__3A0963F66DE9E174");

            entity.ToTable("EST_UF");

            entity.Property(e => e.CdUf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CD_UF");
            entity.Property(e => e.TxNome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TX_NOME");
        });

        modelBuilder.Entity<InfraLogRecupSenha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfraLogRecupSenha");

            entity.Property(e => e.Dtalteracao)
                .HasColumnType("datetime")
                .HasColumnName("DTALTERACAO");
            entity.Property(e => e.Dtsolicitacao)
                .HasColumnType("datetime")
                .HasColumnName("DTSOLICITACAO");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Infrausuarioid)
                .HasMaxLength(36)
                .HasColumnName("INFRAUSUARIOID");
            entity.Property(e => e.IsEfetivado).HasColumnName("IS_EFETIVADO");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infraauthentication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAAUTHENTICATION");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Infrain2fatypeid).HasColumnName("INFRAIN2FATYPEID");
            entity.Property(e => e.Infrainauthtypeid).HasColumnName("INFRAINAUTHTYPEID");
            entity.Property(e => e.Is2faenabled).HasColumnName("IS_2FAENABLED");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infraemailcfg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAEMAILCFG");

            entity.Property(e => e.Confirmentreg).HasColumnName("CONFIRMENTREG");
            entity.Property(e => e.Confirmleit).HasColumnName("CONFIRMLEIT");
            entity.Property(e => e.Emailadress)
                .HasMaxLength(250)
                .HasColumnName("EMAILADRESS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Imapport).HasColumnName("IMAPPORT");
            entity.Property(e => e.Imapserver)
                .HasMaxLength(50)
                .HasColumnName("IMAPSERVER");
            entity.Property(e => e.Infraestabid)
                .HasMaxLength(36)
                .HasColumnName("INFRAESTABID");
            entity.Property(e => e.IsAuthenticated).HasColumnName("IS_AUTHENTICATED");
            entity.Property(e => e.IsSsl).HasColumnName("IS_SSL");
            entity.Property(e => e.IsTls).HasColumnName("IS_TLS");
            entity.Property(e => e.Nomeremet)
                .HasMaxLength(50)
                .HasColumnName("NOMEREMET");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PasswordAng)
                .HasMaxLength(1000)
                .HasColumnName("PASSWORD_ANG");
            entity.Property(e => e.Smtpport).HasColumnName("SMTPPORT");
            entity.Property(e => e.Smtpserver)
                .HasMaxLength(50)
                .HasColumnName("SMTPSERVER");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Timeout).HasColumnName("TIMEOUT");
            entity.Property(e => e.Urlservidor)
                .HasMaxLength(250)
                .HasColumnName("URLSERVIDOR");
            entity.Property(e => e.Username)
                .HasMaxLength(60)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Infraempresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_RQ1_INFRAEMPRESA");

            entity.ToTable("INFRAEMPRESA");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("CODIGO");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasColumnName("NOME");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infraestabelecimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_RQ1_INFRAESTABELECIMENTO");

            entity.ToTable("INFRAESTABELECIMENTO");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Avisoinicial)
                .HasMaxLength(500)
                .HasColumnName("AVISOINICIAL");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasColumnName("CNPJ");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Empresaid)
                .HasMaxLength(36)
                .HasColumnName("EMPRESAID");
            entity.Property(e => e.Idiomaid).HasColumnName("IDIOMAID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsMatriz).HasColumnName("IS_MATRIZ");
            entity.Property(e => e.Nomeexibicao)
                .HasMaxLength(30)
                .HasColumnName("NOMEEXIBICAO");
            entity.Property(e => e.Nomefantasia)
                .HasMaxLength(100)
                .HasColumnName("NOMEFANTASIA");
            entity.Property(e => e.Razaosocial)
                .HasMaxLength(100)
                .HasColumnName("RAZAOSOCIAL");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Infraestabelecimentos)
                .HasForeignKey(d => d.Empresaid)
                .HasConstraintName("OSFRK_OSUSR_RQ1_INFRAESTABELECIMENTO_OSUSR_RQ1_INFRAEMPRESA_EMPRESAID");
        });

        modelBuilder.Entity<Infraestabfavorito>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAESTABFAVORITO");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Infraestabid)
                .HasMaxLength(36)
                .HasColumnName("INFRAESTABID");
            entity.Property(e => e.Infrausuarioid)
                .HasMaxLength(36)
                .HasColumnName("INFRAUSUARIOID");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.IsFavorite).HasColumnName("IS_FAVORITE");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infragrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAGRUPO");

            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("DESCRICAO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("NOME");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infrain2fatype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAIN2FATYPE");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .HasColumnName("NOME");
            entity.Property(e => e.Ordem).HasColumnName("ORDEM");
        });

        modelBuilder.Entity<Infrainauthtype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAINAUTHTYPE");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .HasColumnName("NOME");
            entity.Property(e => e.Ordem).HasColumnName("ORDEM");
        });

        modelBuilder.Entity<Inframnumenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_RQ1_INFRAMNUMENU");

            entity.ToTable("INFRAMNUMENU");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Classicon)
                .HasMaxLength(100)
                .HasColumnName("CLASSICON");
            entity.Property(e => e.Datacreate)
                .HasColumnType("datetime")
                .HasColumnName("DATACREATE");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("DESCRICAO");
            entity.Property(e => e.DescricaoEnglish)
                .HasMaxLength(500)
                .HasColumnName("DESCRICAO_ENGLISH");
            entity.Property(e => e.DescricaoSpanish)
                .HasMaxLength(500)
                .HasColumnName("DESCRICAO_SPANISH");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .HasColumnName("LABEL");
            entity.Property(e => e.LabelEnglish)
                .HasMaxLength(50)
                .HasColumnName("LABEL_ENGLISH");
            entity.Property(e => e.LabelSpanish)
                .HasMaxLength(50)
                .HasColumnName("LABEL_SPANISH");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TxModuloCod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unicoid)
                .HasMaxLength(36)
                .HasColumnName("UNICOID");
            entity.Property(e => e.Url)
                .HasMaxLength(120)
                .HasColumnName("URL");
            entity.Property(e => e.Urldashboard)
                .HasMaxLength(200)
                .HasColumnName("URLDASHBOARD");
        });

        modelBuilder.Entity<Inframnumenuusuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_RQ1_INFRAMNUMENUUSUARIO");

            entity.ToTable("INFRAMNUMENUUSUARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Usuarioid)
                .HasMaxLength(36)
                .HasColumnName("USUARIOID");

            entity.HasOne(d => d.Menu).WithMany(p => p.Inframnumenuusuarios)
                .HasForeignKey(d => d.Menuid)
                .HasConstraintName("OSFRK_OSUSR_RQ1_INFRAMNUMENUUSUARIO_OSUSR_RQ1_INFRAMNUMENU_MENUID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Inframnumenuusuarios)
                .HasForeignKey(d => d.Usuarioid)
                .HasConstraintName("OSFRK_OSUSR_RQ1_INFRAMNUMENUUSUARIO_OSUSR_RQ1_INFRAUSUARIO_USUARIOID");
        });

        modelBuilder.Entity<Infrasegconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRASEGCONFIG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsCaracteresespeciais).HasColumnName("IS_CARACTERESESPECIAIS");
            entity.Property(e => e.IsDropsession).HasColumnName("IS_DROPSESSION");
            entity.Property(e => e.IsLetrasmaiusculas).HasColumnName("IS_LETRASMAIUSCULAS");
            entity.Property(e => e.IsNumeros).HasColumnName("IS_NUMEROS");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Qtninatividade).HasColumnName("QTNINATIVIDADE");
            entity.Property(e => e.Qtnminima).HasColumnName("QTNMINIMA");
            entity.Property(e => e.Qtnrepeticao).HasColumnName("QTNREPETICAO");
            entity.Property(e => e.Qtntentativa).HasColumnName("QTNTENTATIVA");
            entity.Property(e => e.Qtntrocasenha).HasColumnName("QTNTROCASENHA");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infrausuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_RQ1_INFRAUSUARIO");

            entity.ToTable("INFRAUSUARIO");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("ID");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .HasColumnName("CARGO");
            entity.Property(e => e.Datacriacao)
                .HasColumnType("datetime")
                .HasColumnName("DATACRIACAO");
            entity.Property(e => e.Dataultimoacesso)
                .HasColumnType("datetime")
                .HasColumnName("DATAULTIMOACESSO");
            entity.Property(e => e.DtHoraValidadeLogin).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.ForcePswchange).HasColumnName("FORCE_PSWCHANGE");
            entity.Property(e => e.Idiomaid).HasColumnName("IDIOMAID");
            entity.Property(e => e.Infraconfigldap).HasColumnName("INFRACONFIGLDAP");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsBloqueado).HasColumnName("IS_BLOQUEADO");
            entity.Property(e => e.IsExterno).HasColumnName("Is_Externo");
            entity.Property(e => e.Lastlogestabid)
                .HasMaxLength(36)
                .HasColumnName("LASTLOGESTABID");
            entity.Property(e => e.Lastlogsprint)
                .HasMaxLength(50)
                .HasColumnName("LASTLOGSPRINT");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("NOME");
            entity.Property(e => e.Readlastsprint).HasColumnName("READLASTSPRINT");
            entity.Property(e => e.Senha)
                .HasMaxLength(500)
                .HasColumnName("SENHA");
            entity.Property(e => e.Senhahash512)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SENHAHASH512");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .HasColumnName("TELEFONE");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.TxCpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TxCPF");
            entity.Property(e => e.Usachat).HasColumnName("USACHAT");
            entity.Property(e => e.Usaerp).HasColumnName("USAERP");
            entity.Property(e => e.Useroutsystemsid).HasColumnName("USEROUTSYSTEMSID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .HasColumnName("USUARIO");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Infrausuarios)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FRK_INFRAUSUARIO_TENANT");
        });

        modelBuilder.Entity<InfrausuarioImg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAUSUARIO_IMG");

            entity.Property(e => e.Datacriacao)
                .HasColumnType("datetime")
                .HasColumnName("DATACRIACAO");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Imagem).HasColumnName("IMAGEM");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.Usuarioid)
                .HasMaxLength(36)
                .HasColumnName("USUARIOID");
        });

        modelBuilder.Entity<Infrausuariolog1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFRAUSUARIOLOG1");

            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Infrausuarioid)
                .HasMaxLength(36)
                .HasColumnName("INFRAUSUARIOID");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        });

        modelBuilder.Entity<Infrausuariosenhaslog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_INFRAUSUARIOSENHASLOG");

            entity.ToTable("INFRAUSUARIOSENHASLOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Infrausuarioid)
                .HasMaxLength(36)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("INFRAUSUARIOID");
            entity.Property(e => e.IsEffective)
                .HasDefaultValue(false)
                .HasColumnName("IS_EFFECTIVE");
            entity.Property(e => e.Senha)
                .HasMaxLength(500)
                .HasDefaultValue("")
                .HasColumnName("SENHA");
            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");

            entity.HasOne(d => d.Infrausuario).WithMany(p => p.Infrausuariosenhaslogs)
                .HasForeignKey(d => d.Infrausuarioid)
                .HasConstraintName("OSFRK_INFRAUSUARIOSENHASLOG_INFRAUSUARIO_INFRAUSUARIOID");
        });

        modelBuilder.Entity<LocAluguel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Alug__3214EC07C78DD161");

            entity.ToTable("Loc_Aluguel");

            entity.Property(e => e.IsEncerrado).HasColumnName("Is_Encerrado");
            entity.Property(e => e.LocClienteId).HasColumnName("Loc_ClienteId");
            entity.Property(e => e.LocFuncionarioId).HasColumnName("Loc_FuncionarioId");
            entity.Property(e => e.LocVeiculoId).HasColumnName("Loc_VeiculoId");
            entity.Property(e => e.ValorDesconto).HasColumnType("decimal(37, 2)");
            entity.Property(e => e.ValorFinal).HasColumnType("decimal(37, 2)");
            entity.Property(e => e.ValorMulta).HasColumnType("decimal(37, 2)");
            entity.Property(e => e.ValorPrevisto).HasColumnType("decimal(37, 2)");

            entity.HasOne(d => d.LocCliente).WithMany(p => p.LocAluguels)
                .HasForeignKey(d => d.LocClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cliente_Aluguel");

            entity.HasOne(d => d.LocFuncionario).WithMany(p => p.LocAluguels)
                .HasForeignKey(d => d.LocFuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Funcionario_Aluguel");

            entity.HasOne(d => d.LocVeiculo).WithMany(p => p.LocAluguels)
                .HasForeignKey(d => d.LocVeiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Veiculo_Aluguel");
        });

        modelBuilder.Entity<LocCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Clie__3214EC07FC6B92B3");

            entity.ToTable("Loc_Cliente");

            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsEspecial).HasColumnName("Is_Especial");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Rg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RG");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LocEnderecoCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Ende__3214EC0797F12D2C");

            entity.ToTable("Loc_EnderecoCliente");

            entity.Property(e => e.Bairro)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Cep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Complemento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EstadoUf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EstadoUF");
            entity.Property(e => e.LocClienteId).HasColumnName("Loc_ClienteId");
            entity.Property(e => e.Logradouro)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.LocCliente).WithMany(p => p.LocEnderecoClientes)
                .HasForeignKey(d => d.LocClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Endereco_Cliente");
        });

        modelBuilder.Entity<LocFuncionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Func__3214EC07E6D69F7E");

            entity.ToTable("Loc_Funcionario");

            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LocMarca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Marc__3214EC074BD2A1FA");

            entity.ToTable("Loc_Marca");

            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LocTipoVeiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Tipo__3214EC079BB12F44");

            entity.ToTable("Loc_TipoVeiculo");

            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LocVeiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loc_Veic__3214EC074AF87C5E");

            entity.ToTable("Loc_Veiculo");

            entity.Property(e => e.Cor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDisponivel)
                .HasDefaultValue(true)
                .HasColumnName("Is_Disponivel");
            entity.Property(e => e.Modelo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorDiaria).HasColumnType("decimal(37, 2)");

            entity.HasOne(d => d.Marca).WithMany(p => p.LocVeiculos)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Marca_Veiculo");

            entity.HasOne(d => d.TipoVeiculo).WithMany(p => p.LocVeiculos)
                .HasForeignKey(d => d.TipoVeiculoId)
                .HasConstraintName("FK_Tipo_Veiculo");
        });

        modelBuilder.Entity<OssysTenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OSSYS_TE__3214EC271F23F8B4");

            entity.ToTable("OSSYS_TENANT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("Is_Active");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
