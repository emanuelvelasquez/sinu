USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Param_ESCOLARIDAD]    Script Date: 01/06/2020 18:22:44 ******/
CREATE SYNONYM [dbo].[Syn_Param_ESCOLARIDAD] FOR [Parametricas].[dbo].[T122_ESCOLARIDAD]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Parametricas para ver Tabla T122_ESCOLARIDAD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Param_ESCOLARIDAD'
GO
