USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Param_DestVigRelacDerog]    Script Date: 01/06/2020 18:22:44 ******/
CREATE SYNONYM [dbo].[Syn_Param_DestVigRelacDerog] FOR [(localdb)\SINU2020].[Parametrica].[dbo].[DestVigRelacDerog]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Parametricas para ver Tabla DestVigRelacDerog' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Param_DestVigRelacDerog'
GO
