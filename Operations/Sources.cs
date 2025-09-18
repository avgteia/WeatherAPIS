using Weather.Commons;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Weather.Operations.Entities;
using Weather.Commons.Entities;

namespace Weather.Operations
{
    public class Sources
    {
        #region ------------------------------------------------- Private Members ------------------------------------------------------
        // Retrieve the name of this class
        static readonly string ClassName = typeof(Sources).ToString();



        #endregion


        #region ------------------------------------------------- Lazy Variables ------------------------------------------------------
        // Lazy variable for create the [usp_Source_Sel_01] accesor
        static readonly Lazy<DataAccessor<SourcesEntity>> usp_Sources_Sel_01_Accessor = new Lazy<DataAccessor<SourcesEntity>>
            (
                // Constructor invoked on this variable when [Value] property is accessed.
                () =>
                {
                    // variable for map the properties of the indicate entity
                    IRowMapper<SourcesEntity> entityPropetiesMapper = MapBuilder<SourcesEntity>.BuildAllProperties();

                    return DatabaseProvider.ADF_Db.CreateSprocAccessor("usp_Sources_Sel_01",entityPropetiesMapper);
                }
            );

        #endregion

        #region ------------------------------------------------- Public Methods ------------------------------------------------------


        public static SourcesEntity GetByIdService(SourceRequestEntity filters)
        {

            var result = Get(filters).FirstOrDefault();

            return result;
        }


        public static List<SourcesEntity> GetService()
        {

            var request = new SourceRequestEntity();

            var result = Get(request);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static NonQueryResultEntity AddService(SourceAddDto source)
        {
            var result = new NonQueryResultEntity();

            result = Add(source);

            return result;
        }

        
        #endregion

        #region ------------------------------------------------- Private Methods ------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static List<SourcesEntity> Get(SourceRequestEntity filters)
        {
            // Get the source list 
            var sourceList = usp_Sources_Sel_01_Accessor.Value.Execute(
                    filters.idSource
                ).ToList();

            return sourceList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private static NonQueryResultEntity Add(SourceAddDto source)
        {

            var result = new NonQueryResultEntity();

            try
            {
                result.RecordsAffected = DatabaseProvider.ADF_Db.ExecuteNonQuery("usp_Sources_Ins_01",
                    source.idSource
                    , source.Source
                    , source.DataBaseName);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        #endregion
    }
}
