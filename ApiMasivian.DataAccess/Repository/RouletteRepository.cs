using ApiMasivian.DataAccess.Contracts.Entities;
using ApiMasivian.DataAccess.Contracts.Repository;
using EasyCaching.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiMasivian.DataAccess.Repository
{
    public class RouletteRepository : DBConexion, IRouletteRepository
    {
        public RouletteRepository() : base() { }
        private StringBuilder query;
        public bool Open(string id)
        {
            return ExecuteOpenRoulette(id);
        }
        public Roulette Save(Roulette roulette)
        {
            ExecuteSave(roulette);
            return roulette;
        }
        public bool ExecuteSave(Roulette temp)
        {
            query = new StringBuilder();
            bool isSuccess = false;
            query.Append("INSERT INTO roulettes (id) ");
            query.Append("VALUES (?id) ");
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("?id", temp.id));
            try
            {
                this.OpenConnection();
                this.BeginTransaccion();
                isSuccess = this.Execute(query.ToString(), parametros.ToArray());
                this.Commit();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return isSuccess;
        }
        public bool ExecuteOpenRoulette(string id)
        {
            query = new StringBuilder();
            bool isSuccess = false;
            query.Append("UPDATE roulettes SET date_open = NOW() ");
            query.Append("WHERE id = ?id ");
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("?id", id));

            try
            {
                this.OpenConnection();
                this.BeginTransaccion();
                isSuccess = this.Execute(query.ToString(), parametros.ToArray());
                this.Commit();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return isSuccess;
        }
        public Roulette GetById(string id)
        {
            List<Roulette> list = new List<Roulette>();
            MySqlDataReader reader = default(MySqlDataReader);
            Hashtable listParam = new Hashtable();
            query = new StringBuilder();
            query.Append("SELECT * FROM roulettes WHERE id = ?id ");
            listParam.Add("?id", id);
            try
            {
                this.OpenConnection();
                reader = this.ExecuteSelect(query.ToString(), this.GetParametros(listParam));
                while (reader.Read())
                {
                    Roulette roulette = new Roulette();
                    roulette.id = reader.GetString("id");
                    if (reader.IsDBNull(reader.GetOrdinal("date_open")) == false) { roulette.dateOpen = reader.GetDateTime("date_open"); }
                    if (reader.IsDBNull(reader.GetOrdinal("date_closed")) == false) { roulette.dateClose = reader.GetDateTime("date_closed"); }
                    if (reader.IsDBNull(reader.GetOrdinal("is_closed")) == false) { roulette.isClosed = reader.GetBoolean("is_closed"); }
                    list.Add(roulette);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return list.FirstOrDefault();
        }
        public List<Roulette> GetAll()
        {
            List<Roulette> list = new List<Roulette>();
            MySqlDataReader reader = default(MySqlDataReader);
            Hashtable listParam = new Hashtable();
            query = new StringBuilder();
            query.Append("SELECT * FROM roulettes ");
            try
            {
                this.OpenConnection();
                reader = this.ExecuteSelect(query.ToString(), this.GetParametros(listParam));
                while (reader.Read())
                {
                    Roulette roulette = new Roulette();
                    roulette.id = reader.GetString("id");
                    if (reader.IsDBNull(reader.GetOrdinal("date_open")) == false) { roulette.dateOpen = reader.GetDateTime("date_open"); }
                    if (reader.IsDBNull(reader.GetOrdinal("date_closed")) == false) { roulette.dateClose = reader.GetDateTime("date_closed"); }
                    if (reader.IsDBNull(reader.GetOrdinal("is_closed")) == false) { roulette.isClosed = reader.GetBoolean("is_closed"); }
                    list.Add(roulette);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return list;
        }
        public bool SaveBet(BetRoulette bet)
        {
            return ExecuteSaveBet(bet);
        }
        public bool ExecuteSaveBet(BetRoulette bet)
        {
            query = new StringBuilder();
            bool isSuccess = false;
            query.Append("INSERT INTO bet_roulette (id, id_roulette, id_user, number, id_color, money) ");
            query.Append("VALUES (?id,?idRoulette,?idUser,?number,?idColor, ?money) ");
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("?id", bet.id));
            parametros.Add(new MySqlParameter("?idUser", bet.idUser));
            parametros.Add(new MySqlParameter("?idColor", bet.idColor));
            parametros.Add(new MySqlParameter("?idRoulette", bet.idRoulette));
            parametros.Add(new MySqlParameter("?number", bet.number));
            parametros.Add(new MySqlParameter("?money", bet.money));
            try
            {
                this.OpenConnection();
                this.BeginTransaccion();
                isSuccess = this.Execute(query.ToString(), parametros.ToArray());
                this.Commit();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return isSuccess;
        }
        public List<BetRoulette> GetAllBetByIdRoulette(string id)
        {
            List<BetRoulette> list = new List<BetRoulette>();
            MySqlDataReader reader = default(MySqlDataReader);
            Hashtable listParam = new Hashtable();
            query = new StringBuilder();
            query.Append("SELECT * FROM bet_roulette WHERE id_roulette = ?idRoulette ");
            listParam.Add("?idRoulette", id);
            try
            {
                this.OpenConnection();
                reader = this.ExecuteSelect(query.ToString(), this.GetParametros(listParam));
                while (reader.Read())
                {
                    BetRoulette betRoulette = new BetRoulette();
                    betRoulette.id = reader.GetString("id");
                    if (reader.IsDBNull(reader.GetOrdinal("id_roulette")) == false) { betRoulette.idRoulette = reader.GetString("id_roulette"); }
                    if (reader.IsDBNull(reader.GetOrdinal("id_color")) == false) { betRoulette.idColor = reader.GetString("id_color"); }
                    if (reader.IsDBNull(reader.GetOrdinal("id_user")) == false) { betRoulette.idUser = reader.GetString("id_user"); }
                    if (reader.IsDBNull(reader.GetOrdinal("number")) == false) { betRoulette.number = reader.GetInt32("number"); }
                    if (reader.IsDBNull(reader.GetOrdinal("money")) == false) { betRoulette.money = reader.GetDouble("money"); }
                    list.Add(betRoulette);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return list;
        }
        public bool Close(string id)
        {
            return ExecuteClose(id);
        }
        public bool ExecuteClose(string id)
        {
            query = new StringBuilder();
            bool isSuccess = false;
            query.Append("UPDATE roulettes SET is_closed = TRUE, date_closed = NOW() ");
            query.Append("WHERE id = ?id ");
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("?id", id));
            try
            {
                this.OpenConnection();
                this.BeginTransaccion();
                isSuccess = this.Execute(query.ToString(), parametros.ToArray());
                this.Commit();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return isSuccess;
        }
        public ColorRoulette GetColorRouletteById(string id)
        {
            List<ColorRoulette> list = new List<ColorRoulette>();
            MySqlDataReader reader = default(MySqlDataReader);
            Hashtable listParam = new Hashtable();
            query = new StringBuilder();
            query.Append("SELECT * FROM color_roulette WHERE id = ?id ");
            listParam.Add("?id", id);
            try
            {
                this.OpenConnection();
                reader = this.ExecuteSelect(query.ToString(), this.GetParametros(listParam));
                while (reader.Read())
                {
                    ColorRoulette colorRoulette = new ColorRoulette();
                    if (reader.IsDBNull(reader.GetOrdinal("id")) == false) { colorRoulette.id = reader.GetString("id"); }
                    if (reader.IsDBNull(reader.GetOrdinal("color")) == false) { colorRoulette.color = reader.GetString("color"); }
                    if (reader.IsDBNull(reader.GetOrdinal("is_even_number")) == false) { colorRoulette.isEvenNumber = reader.GetBoolean("is_even_number"); }
                    list.Add(colorRoulette);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return list.FirstOrDefault();
        }
    }
}
