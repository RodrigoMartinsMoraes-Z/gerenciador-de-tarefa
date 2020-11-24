﻿// <auto-generated />
using System;
using GerenciadorDeTarefas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GerenciadorDeTarefas.Context.Migrations
{
    [DbContext(typeof(ContextoDeDados))]
    [Migration("20201124144113_correcaoprojeto")]
    partial class correcaoprojeto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Equipes.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.ManyToMany.EquipeUsuario", b =>
                {
                    b.Property<int>("IdEquipe")
                        .HasColumnType("integer");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.HasKey("IdEquipe", "IdUsuario");

                    b.HasIndex("IdUsuario");

                    b.ToTable("EquipeUsuario");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Objetivos.Objetivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Adicionado")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Detalhes")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Finalizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdProjeto")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Previsao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Prioridade")
                        .HasColumnType("integer");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdProjeto");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Pessoas.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Projetos.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("IdEquipe")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipe");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Adicionado")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Detalhes")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Finalizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdObjetivo")
                        .HasColumnType("integer");

                    b.Property<int>("IdProjeto")
                        .HasColumnType("integer");

                    b.Property<int?>("IdTarefaPrincipal")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Previsao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Prioridade")
                        .HasColumnType("integer");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdObjetivo");

                    b.HasIndex("IdProjeto");

                    b.HasIndex("IdTarefaPrincipal");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Usuarios.Usuario", b =>
                {
                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("IdPessoa");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.ManyToMany.EquipeUsuario", b =>
                {
                    b.HasOne("GerenciadorDeTarefas.Domain.Equipes.Equipe", "Equipe")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdEquipe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorDeTarefas.Domain.Usuarios.Usuario", "Usuario")
                        .WithMany("Equipes")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Objetivos.Objetivo", b =>
                {
                    b.HasOne("GerenciadorDeTarefas.Domain.Projetos.Projeto", "Projeto")
                        .WithMany("Objetivos")
                        .HasForeignKey("IdProjeto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Projetos.Projeto", b =>
                {
                    b.HasOne("GerenciadorDeTarefas.Domain.Equipes.Equipe", "Equipe")
                        .WithMany("Projetos")
                        .HasForeignKey("IdEquipe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.HasOne("GerenciadorDeTarefas.Domain.Objetivos.Objetivo", "Objetivo")
                        .WithMany("Tarefas")
                        .HasForeignKey("IdObjetivo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorDeTarefas.Domain.Projetos.Projeto", "Projeto")
                        .WithMany("Tarefas")
                        .HasForeignKey("IdProjeto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorDeTarefas.Domain.Tarefas.Tarefa", "TarefaPrincipal")
                        .WithMany("SubTarefas")
                        .HasForeignKey("IdTarefaPrincipal");

                    b.Navigation("Objetivo");

                    b.Navigation("Projeto");

                    b.Navigation("TarefaPrincipal");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Usuarios.Usuario", b =>
                {
                    b.HasOne("GerenciadorDeTarefas.Domain.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Equipes.Equipe", b =>
                {
                    b.Navigation("Projetos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Objetivos.Objetivo", b =>
                {
                    b.Navigation("Tarefas");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Projetos.Projeto", b =>
                {
                    b.Navigation("Objetivos");

                    b.Navigation("Tarefas");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.Navigation("SubTarefas");
                });

            modelBuilder.Entity("GerenciadorDeTarefas.Domain.Usuarios.Usuario", b =>
                {
                    b.Navigation("Equipes");
                });
#pragma warning restore 612, 618
        }
    }
}
