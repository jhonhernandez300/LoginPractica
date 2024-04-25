using Dapper;
using LoginPractica.Interfaces;
using LoginPractica.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace LoginPractica
{
    public class UsuariosRepository: IUsuarios
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public UsuariosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        //public async Task<IEnumerable<Usuario>> Get()
        //{
        //    return await _connection
        //        .QueryAsync<Usuario>("ObtenerUsuarioPorCorreoYPassword", commandType: CommandType.StoredProcedure);
        //}
        //public async Task<Usuario> Find(int id)
        //{
        //    var parmeters = new DynamicParameters();
        //    parmeters.Add("@UsuarioId", id);
        //    return await _connection
        //        .QueryFirstOrDefaultAsync<Usuario>("GetCategoryById", parmeters, commandType: CommandType.StoredProcedure);
        //}

        public async Task<Usuario> Find(string correo, string password)
        {
            var parmeters = new DynamicParameters();
            parmeters.Add("@Correo", correo);
            parmeters.Add("@ElPassword", password);
            return await _connection.QueryFirstOrDefaultAsync<Usuario>(
                "ObtenerUsuarioPorCorreoYPassword", 
                parmeters, 
                commandType: CommandType.StoredProcedure
            );
        }

        //public async Task<CategoriesModel> Add(CategoriesModel model)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@f_uid", Guid.NewGuid());
        //    parameters.Add("@f_category_name", model.f_category_name);
        //    parameters.Add("", model.f_create_date = DateTime.Now);
        //    await _connection.ExecuteAsync("AddNewCategoty", parameters, commandType: CommandType.StoredProcedure);
        //    return model;
        //}
        //public async Task<CategoriesModel> Update(CategoriesModel model)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@f_category_name", model.f_category_name);
        //    parameters.Add("@f_update_date", model.f_update_date = DateTime.Now);

        //    await _connection.ExecuteAsync("UpdateCategory", parameters, commandType: CommandType.StoredProcedure);
        //    return model;
        //}
        //public async Task<int> Remove(CategoriesModel model)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@f_uid", model.f_uid);
        //    parameters.Add("f_delete_date", model.f_delete_date = DateTime.Now);
        //    return await _connection.ExecuteAsync("DeleteCategory", parameters, commandType: CommandType.StoredProcedure);
        //}
    }
}
