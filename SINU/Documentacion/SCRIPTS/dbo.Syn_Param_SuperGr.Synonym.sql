USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Param_SuperGr]    Script Date: 01/06/2020 18:22:45 ******/
CREATE SYNONYM [dbo].[Syn_Param_SuperGr] FOR [Siecsi14d].[Parametricas].[dbo].[T030_GRADOS_SUP_NUM]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Parametricas para ver Tabla [T030_GRADOS_SUP_NUM]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Param_SuperGr'
GO
