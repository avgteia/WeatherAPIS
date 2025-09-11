using Weather.Commons;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Weather.Operations.Entities;

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
                // Constructor invoked on this variable when [Value] property is accessed
                () =>
                {
                    // variable for map the properties of the indicate entity
                    IRowMapper<SourcesEntity> entityPropetiesMapper = MapBuilder<SourcesEntity>.BuildAllProperties();

                    return DatabaseProvider.ADF_Db.CreateSprocAccessor("usp_Sources_Sel_01",entityPropetiesMapper);
                }
            );


        #endregion

        #region ------------------------------------------------- Public Methods ------------------------------------------------------
        
        public static List<SourcesEntity> Get()
        {
            // Get the source list 
            var sourceList = usp_Sources_Sel_01_Accessor.Value.Execute().ToList();

            return sourceList;
        }
        #endregion
    }
}
