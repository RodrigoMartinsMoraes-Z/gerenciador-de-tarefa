﻿using GerenciadorDeTarefas.Domain.Projetos;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeTarefas.Context.Types
{
    public class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.Tarefas).WithOne(t => t.Projeto).HasForeignKey(p => p.IdProjeto);
            builder.HasMany(p => p.Objetivos).WithOne(t => t.Projeto).HasForeignKey(p => p.IdProjeto);

        }
    }
}
