using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain.Enum;
using Domain.Models;
using EMRepository;
using FirebirdSql.Data.FirebirdClient;

namespace Repository
{
    public class AlunoRepository : RepositorioAbstrato<Aluno>
    {
        FireBirdDataBase fireBase = new FireBirdDataBase();

        public override IEnumerable<Aluno> GetAll()
        {
             string selectSQL = "SELECT MATRICULA,NOME,SEXO,DTNASCIMENTO,CPF FROM TBALUNO A ORDER BY NOME";

            List<Aluno> alunos = new List<Aluno>();

            using (FbCommand cmd = new FbCommand(selectSQL, fireBase.connection))
            {
                using (FbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Aluno aluno = new Aluno()
                        {
                            Matricula = reader.GetInt32(reader.GetOrdinal("MATRICULA")),
                            Nome = reader.IsDBNull(reader.GetOrdinal("NOME")) ? null : reader.GetString(reader.GetOrdinal("NOME")),
                            CPF = reader.IsDBNull(reader.GetOrdinal("CPF")) ? null : reader.GetString(reader.GetOrdinal("CPF")),
                            Sexo = (Sexo)reader.GetInt32(reader.GetOrdinal("SEXO"))
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("DTNASCIMENTO")))
                        {
                            string dtnascimentoString = reader.GetString(reader.GetOrdinal("DTNASCIMENTO"));
                        if (DateTime.TryParse(dtnascimentoString, out DateTime nascimento))
                        {
                            aluno.Nascimento = nascimento;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Erro na conversão da data!.");
                        }

                        }

                        alunos.Add(aluno);
                    }
                }
            }
                return alunos;
        }

        public override Aluno Get(string predicate, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override void Add(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Aluno entity)
        {
            throw new NotImplementedException();
        }

    }
}