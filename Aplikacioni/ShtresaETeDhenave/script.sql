USE [Baza]
GO
/****** Object:  Table [dbo].[Aeroplanat]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeroplanat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LinjaAjroreID] [int] NOT NULL,
	[TipiAeroplanitID] [int] NOT NULL,
	[MarkaAeroplanitID] [int] NOT NULL,
	[NumriUleseve] [int] NOT NULL,
 CONSTRAINT [PK_Aeroplanat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Agjensionet]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Agjensionet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Agjensionet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fluturimet]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fluturimet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AeroplaniID] [int] NOT NULL,
	[QytetiID] [int] NOT NULL,
	[DataNisjes] [datetime] NOT NULL,
	[OraNisjes] [datetime] NOT NULL,
	[PerdoruesiAeroportitID] [int] NOT NULL,
	[FluturimiAnuluar] [int] NOT NULL,
	[Cmimi] [decimal](18, 2) NOT NULL,
	[CmimiKthyes] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Fluturimet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LinjatAjrore]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LinjatAjrore](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LinjatAjrore] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MarkatAeroplanave]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MarkatAeroplanave](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[TipiAeroplanitID] [int] NOT NULL,
 CONSTRAINT [PK_MarkatAeroplanave] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PerdoruesitAeroportit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PerdoruesitAeroportit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[NumriIdentifikues] [varchar](50) NOT NULL,
	[DokumentiIdentifikues] [int] NOT NULL,
	[Datelindja] [datetime] NOT NULL,
	[Vendlindja] [varchar](50) NOT NULL,
	[Vendbanimi] [varchar](50) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[TelefoniFiks] [varchar](50) NOT NULL,
	[TelefoniMobil] [varchar](50) NOT NULL,
	[Emaili] [varchar](50) NOT NULL,
	[Pseudonimi] [varchar](50) NOT NULL,
	[Fjalekalimi] [varchar](50) NOT NULL,
	[Privilegji] [int] NOT NULL,
 CONSTRAINT [PK_Perdoruesit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PerdoruesitAgjensionit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PerdoruesitAgjensionit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[NumriIdentifikues] [varchar](50) NOT NULL,
	[DokumentiIdentifikues] [int] NOT NULL,
	[Datelindja] [datetime] NOT NULL,
	[Vendlindja] [varchar](50) NOT NULL,
	[Vendbanimi] [varchar](50) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[TelefoniFiks] [varchar](50) NOT NULL,
	[TelefoniMobil] [varchar](50) NOT NULL,
	[Emaili] [varchar](50) NOT NULL,
	[AgjensioniID] [int] NOT NULL,
	[Pseudonimi] [varchar](50) NOT NULL,
	[Fjalekalimi] [varchar](50) NOT NULL,
	[Privilegji] [int] NOT NULL,
 CONSTRAINT [PK_PerdoruesitAgjensionit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Qytetet]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Qytetet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[ShtetiID] [int] NOT NULL,
 CONSTRAINT [PK_Qytetet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rezervimet]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervimet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PerdoruesiAgjensionitID] [int] NOT NULL,
	[FluturimiID] [int] NOT NULL,
	[UdhetariID] [int] NOT NULL,
	[UlesjaID] [int] NOT NULL,
	[LlojiRezervimit] [int] NOT NULL,
	[Cmimi] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Rezervimet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shtetet]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shtetet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Shtetet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipetAeroplanave]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipetAeroplanave](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipetAeroplanave] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Udhetaret]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Udhetaret](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[NumriIdentifikues] [varchar](50) NOT NULL,
	[DokumentiIdentifikues] [int] NOT NULL,
	[Datelindja] [datetime] NOT NULL,
	[Vendlindja] [varchar](50) NOT NULL,
	[Vendbanimi] [varchar](50) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[TelefoniFiks] [varchar](50) NOT NULL,
	[TelefoniMobil] [varchar](50) NOT NULL,
	[Emaili] [varchar](50) NOT NULL,
	[PerdoruesiAgjensionitID] [int] NOT NULL,
 CONSTRAINT [PK_Udhetaret] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Uleset]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uleset](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Numri] [int] NOT NULL,
	[AeroplaniID] [int] NOT NULL,
	[UlesjaEZene] [int] NOT NULL,
 CONSTRAINT [PK_Uleset] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Aeroplanat]  WITH CHECK ADD  CONSTRAINT [FK_Aeroplanat_LinjatAjrore] FOREIGN KEY([LinjaAjroreID])
REFERENCES [dbo].[LinjatAjrore] ([ID])
GO
ALTER TABLE [dbo].[Aeroplanat] CHECK CONSTRAINT [FK_Aeroplanat_LinjatAjrore]
GO
ALTER TABLE [dbo].[Aeroplanat]  WITH CHECK ADD  CONSTRAINT [FK_Aeroplanat_MarkatAeroplanave] FOREIGN KEY([MarkaAeroplanitID])
REFERENCES [dbo].[MarkatAeroplanave] ([ID])
GO
ALTER TABLE [dbo].[Aeroplanat] CHECK CONSTRAINT [FK_Aeroplanat_MarkatAeroplanave]
GO
ALTER TABLE [dbo].[Aeroplanat]  WITH CHECK ADD  CONSTRAINT [FK_Aeroplanat_TipetAeroplanave] FOREIGN KEY([TipiAeroplanitID])
REFERENCES [dbo].[TipetAeroplanave] ([ID])
GO
ALTER TABLE [dbo].[Aeroplanat] CHECK CONSTRAINT [FK_Aeroplanat_TipetAeroplanave]
GO
ALTER TABLE [dbo].[Fluturimet]  WITH CHECK ADD  CONSTRAINT [FK_Fluturimet_Aeroplanat] FOREIGN KEY([AeroplaniID])
REFERENCES [dbo].[Aeroplanat] ([ID])
GO
ALTER TABLE [dbo].[Fluturimet] CHECK CONSTRAINT [FK_Fluturimet_Aeroplanat]
GO
ALTER TABLE [dbo].[Fluturimet]  WITH CHECK ADD  CONSTRAINT [FK_Fluturimet_PerdoruesitAeroportit] FOREIGN KEY([PerdoruesiAeroportitID])
REFERENCES [dbo].[PerdoruesitAeroportit] ([ID])
GO
ALTER TABLE [dbo].[Fluturimet] CHECK CONSTRAINT [FK_Fluturimet_PerdoruesitAeroportit]
GO
ALTER TABLE [dbo].[Fluturimet]  WITH CHECK ADD  CONSTRAINT [FK_Fluturimet_Qytetet] FOREIGN KEY([QytetiID])
REFERENCES [dbo].[Qytetet] ([ID])
GO
ALTER TABLE [dbo].[Fluturimet] CHECK CONSTRAINT [FK_Fluturimet_Qytetet]
GO
ALTER TABLE [dbo].[MarkatAeroplanave]  WITH CHECK ADD  CONSTRAINT [FK_MarkatAeroplanave_TipetAeroplanave] FOREIGN KEY([TipiAeroplanitID])
REFERENCES [dbo].[TipetAeroplanave] ([ID])
GO
ALTER TABLE [dbo].[MarkatAeroplanave] CHECK CONSTRAINT [FK_MarkatAeroplanave_TipetAeroplanave]
GO
ALTER TABLE [dbo].[PerdoruesitAgjensionit]  WITH CHECK ADD  CONSTRAINT [FK_PerdoruesitAgjensionit_Agjensionet] FOREIGN KEY([AgjensioniID])
REFERENCES [dbo].[Agjensionet] ([ID])
GO
ALTER TABLE [dbo].[PerdoruesitAgjensionit] CHECK CONSTRAINT [FK_PerdoruesitAgjensionit_Agjensionet]
GO
ALTER TABLE [dbo].[Qytetet]  WITH CHECK ADD  CONSTRAINT [FK_Qytetet_Shtetet] FOREIGN KEY([ShtetiID])
REFERENCES [dbo].[Shtetet] ([ID])
GO
ALTER TABLE [dbo].[Qytetet] CHECK CONSTRAINT [FK_Qytetet_Shtetet]
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD  CONSTRAINT [FK_Rezervimet_Fluturimet] FOREIGN KEY([FluturimiID])
REFERENCES [dbo].[Fluturimet] ([ID])
GO
ALTER TABLE [dbo].[Rezervimet] CHECK CONSTRAINT [FK_Rezervimet_Fluturimet]
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD  CONSTRAINT [FK_Rezervimet_PerdoruesitAgjensionit] FOREIGN KEY([PerdoruesiAgjensionitID])
REFERENCES [dbo].[PerdoruesitAgjensionit] ([ID])
GO
ALTER TABLE [dbo].[Rezervimet] CHECK CONSTRAINT [FK_Rezervimet_PerdoruesitAgjensionit]
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD  CONSTRAINT [FK_Rezervimet_Udhetaret] FOREIGN KEY([UdhetariID])
REFERENCES [dbo].[Udhetaret] ([ID])
GO
ALTER TABLE [dbo].[Rezervimet] CHECK CONSTRAINT [FK_Rezervimet_Udhetaret]
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD  CONSTRAINT [FK_Rezervimet_Uleset] FOREIGN KEY([UlesjaID])
REFERENCES [dbo].[Uleset] ([ID])
GO
ALTER TABLE [dbo].[Rezervimet] CHECK CONSTRAINT [FK_Rezervimet_Uleset]
GO
ALTER TABLE [dbo].[Udhetaret]  WITH CHECK ADD  CONSTRAINT [FK_Udhetaret_PerdoruesitAgjensionit] FOREIGN KEY([PerdoruesiAgjensionitID])
REFERENCES [dbo].[PerdoruesitAgjensionit] ([ID])
GO
ALTER TABLE [dbo].[Udhetaret] CHECK CONSTRAINT [FK_Udhetaret_PerdoruesitAgjensionit]
GO
ALTER TABLE [dbo].[Uleset]  WITH CHECK ADD  CONSTRAINT [FK_Uleset_Aeroplanat] FOREIGN KEY([AeroplaniID])
REFERENCES [dbo].[Aeroplanat] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uleset] CHECK CONSTRAINT [FK_Uleset_Aeroplanat]
GO
/****** Object:  StoredProcedure [dbo].[AeroplanatLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AeroplanatLexo]

@fjalakyce varchar(50)

as

select * from Aeroplanat where

LinjaAjroreID in (select ID from LinjatAjrore where Emri like @fjalakyce + '%') or
TipiAeroplanitID in (select ID from TipetAeroplanave where Emri like @fjalakyce + '%') or
MarkaAeroplanitID in (select ID from MarkatAeroplanave where Emri like @fjalakyce + '%')

GO
/****** Object:  StoredProcedure [dbo].[AeroplanatLexoSipasLinjes]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AeroplanatLexoSipasLinjes]

@LinjaAjroreID int

as

select * from Aeroplanat where LinjaAjroreID = @LinjaAjroreID
GO
/****** Object:  StoredProcedure [dbo].[AeroplaniFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AeroplaniFshi]

@ID int

as

delete from Aeroplanat where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[AeroplaniLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AeroplaniLexo]

@ID int

as

select * from Aeroplanat where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[AeroplaniNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AeroplaniNdrysho]

@ID int,
@LinjaAjroreID int,
@TipiAeroplanitID int,
@MarkaAeroplanitID int,
@NumriUleseve int

as

update Aeroplanat set

LinjaAjroreID = @LinjaAjroreID,
TipiAeroplanitID = @TipiAeroplanitID,
MarkaAeroplanitID = @MarkaAeroplanitID,
NumriUleseve = @NumriUleseve

where ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[AeroplaniShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AeroplaniShkruaj]

@LinjaAjroreID int,
@TipiAeroplanitID int,
@MarkaAeroplanitID int,
@NumriUleseve int

as

insert Aeroplanat values
(
  @LinjaAjroreID,
  @TipiAeroplanitID,
  @MarkaAeroplanitID,
  @NumriUleseve
)

select cast(@@identity as int) as ID



GO
/****** Object:  StoredProcedure [dbo].[AgjensionetLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgjensionetLexo]

@fjalakyce varchar(50)

as

select * from Agjensionet where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[AgjensioniFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgjensioniFshi]

@ID int

as

delete from Agjensionet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[AgjensioniLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgjensioniLexo]

@ID int

as

select * from Agjensionet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[AgjensioniNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgjensioniNdrysho]

@ID int,
@Emri varchar(50)

as

update Agjensionet set

Emri = @Emri

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[AgjensioniShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgjensioniShkruaj]

@Emri varchar(50)

as

insert Agjensionet values
(
  @Emri
)

select cast(@@identity as int) as ID
GO
/****** Object:  StoredProcedure [dbo].[FluturimetLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FluturimetLexo]

@fjalakyce varchar(50)

as

select * from Fluturimet where 

AeroplaniID in (select ID from Aeroplanat where TipiAeroplanitID in (select ID from TipetAeroplanave where Emri like @fjalakyce + '%'))

GO
/****** Object:  StoredProcedure [dbo].[FluturimetLexoSipasStatusit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FluturimetLexoSipasStatusit]

@FluturimiAnuluar int

as

select * from Fluturimet where FluturimiAnuluar = @FluturimiAnuluar
GO
/****** Object:  StoredProcedure [dbo].[FluturimiFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FluturimiFshi]

@ID int

as

delete from Fluturimet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[FluturimiLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FluturimiLexo]

@ID int

as

select * from Fluturimet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[FluturimiNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FluturimiNdrysho]

@ID int,
@AeroplaniID int,
@QytetiID int,
@DataNisjes datetime,
@OraNisjes datetime,
@PerdoruesiAeroportitID int,
@FluturimiAnuluar int,
@Cmimi decimal(18, 2),
@CmimiKthyes decimal(18, 2)

as

update Fluturimet set

AeroplaniID = @AeroplaniID,
QytetiID = @QytetiID,
DataNisjes = @DataNisjes,
OraNisjes = @OraNisjes,
PerdoruesiAeroportitID = @PerdoruesiAeroportitID,
FluturimiAnuluar = @FluturimiAnuluar,
Cmimi = @Cmimi,
CmimiKthyes = @CmimiKthyes

where ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[FluturimiShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FluturimiShkruaj]

@AeroplaniID int,
@QytetiID int,
@DataNisjes datetime,
@OraNisjes datetime,
@PerdoruesiAeroportitID int,
@FluturimiAnuluar int,
@Cmimi decimal(18, 2),
@CmimiKthyes decimal(18, 2)

as

insert Fluturimet values
(
  @AeroplaniID,
  @QytetiID,
  @DataNisjes,
  @OraNisjes,
  @PerdoruesiAeroportitID,
  @FluturimiAnuluar,
  @Cmimi,
  @CmimiKthyes
)

select cast(@@identity as int) as ID


GO
/****** Object:  StoredProcedure [dbo].[LinjaAjroreFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LinjaAjroreFshi]

@ID int

as

delete from LinjatAjrore where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[LinjaAjroreLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LinjaAjroreLexo]

@ID int

as

select * from LinjatAjrore where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[LinjaAjroreNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LinjaAjroreNdrysho]

@ID int,
@Emri varchar(50)

as

update LinjatAjrore set

Emri = @Emri

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[LinjaAjroreShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LinjaAjroreShkruaj]

@Emri varchar(50)

as

insert LinjatAjrore values
(
  @Emri
)

select cast(@@identity as int) as ID
GO
/****** Object:  StoredProcedure [dbo].[LinjatAjroreLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LinjatAjroreLexo]

@fjalakyce varchar(50)

as

select * from LinjatAjrore where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[MarkaAeroplanitFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkaAeroplanitFshi]

@ID int

as

delete from MarkatAeroplanave where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[MarkaAeroplanitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkaAeroplanitLexo]

@ID int

as

select * from MarkatAeroplanave where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[MarkaAeroplanitNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkaAeroplanitNdrysho]

@ID int,
@Emri varchar(50),
@TipiAeroplanitID int

as

update MarkatAeroplanave set

Emri = @Emri,
TipiAeroplanitID = @TipiAeroplanitID

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[MarkaAeroplanitShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkaAeroplanitShkruaj]

@Emri varchar(50),
@TipiAeroplanitID int

as

insert MarkatAeroplanave values
(
  @Emri,
  @TipiAeroplanitID
)

select cast(@@identity as int) as ID
GO
/****** Object:  StoredProcedure [dbo].[MarkatAeroplanaveLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkatAeroplanaveLexo]

@fjalakyce varchar(50)

as

select * from MarkatAeroplanave where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[MarkatAeroplanaveLexoSipasTipit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MarkatAeroplanaveLexoSipasTipit]

@TipiAeroplanitID int

as

select * from MarkatAeroplanave where TipiAeroplanitID = @TipiAeroplanitID
GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAeroportitFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAeroportitFshi]

@ID int

as

delete from PerdoruesitAeroportit where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAeroportitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAeroportitLexo]

@ID int

as

select * from PerdoruesitAeroportit where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAeroportitNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAeroportitNdrysho]

@ID int,
@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@Pseudonimi varchar(50),
@Fjalekalimi varchar(50),
@Privilegji int

as

update PerdoruesitAeroportit set

Emri = @Emri,
Mbiemri = @Mbiemri,
NumriIdentifikues = @NumriIdentifikues,
DokumentiIdentifikues = @DokumentiIdentifikues,
Datelindja = @Datelindja,
Vendlindja = @Vendlindja,
Vendbanimi = @Vendbanimi,
Adresa = @Adresa,
TelefoniFiks = @TelefoniFiks,
TelefoniMobil = @TelefoniMobil,
Emaili = @Emaili,
Pseudonimi = @Pseudonimi,
Fjalekalimi = @Fjalekalimi,
Privilegji = @Privilegji

where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAeroportitShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAeroportitShkruaj]

@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@Pseudonimi varchar(50),
@Fjalekalimi varchar(50),
@Privilegji int

as

insert PerdoruesitAeroportit values
(
  @Emri,
  @Mbiemri,
  @NumriIdentifikues,
  @DokumentiIdentifikues,
  @Datelindja,
  @Vendlindja,
  @Vendbanimi,
  @Adresa,
  @TelefoniFiks,
  @TelefoniMobil,
  @Emaili,
  @Pseudonimi,
  @Fjalekalimi,
  @Privilegji
)

select cast(@@identity as int) as ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAgjensionitFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PerdoruesiAgjensionitFshi]

@ID int

as

delete from PerdoruesitAgjensioneve where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAgjensionitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAgjensionitLexo]

@ID int

as

select * from PerdoruesitAgjensionit where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAgjensionitNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAgjensionitNdrysho]

@ID int,
@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@AgjensioniID int,
@Pseudonimi varchar(50),
@Fjalekalimi varchar(50),
@Privilegji int

as

update PerdoruesitAgjensionit set

Emri = @Emri,
Mbiemri = @Mbiemri,
NumriIdentifikues = @NumriIdentifikues,
DokumentiIdentifikues = @DokumentiIdentifikues,
Datelindja = @Datelindja,
Vendlindja = @Vendlindja,
Vendbanimi = @Vendbanimi,
Adresa = @Adresa,
TelefoniFiks = @TelefoniFiks,
TelefoniMobil = @TelefoniMobil,
Emaili = @Emaili,
AgjensioniID = @AgjensioniID,
Pseudonimi = @Pseudonimi,
Fjalekalimi = @Fjalekalimi,
Privilegji = @Privilegji

where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesiAgjensionitShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesiAgjensionitShkruaj]

@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@AgjensioniID int,
@Pseudonimi varchar(50),
@Fjalekalimi varchar(50),
@Privilegji int

as

insert PerdoruesitAgjensionit values
(
  @Emri,
  @Mbiemri,
  @NumriIdentifikues,
  @DokumentiIdentifikues,
  @Datelindja,
  @Vendlindja,
  @Vendbanimi,
  @Adresa,
  @TelefoniFiks,
  @TelefoniMobil,
  @Emaili,
  @AgjensioniID,
  @Pseudonimi,
  @Fjalekalimi,
  @Privilegji
)

select cast(@@identity as int) as ID

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesitAeroportitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PerdoruesitAeroportitLexo]

@fjalakyce varchar(50)

as

select * from PerdoruesitAeroportit where

Emri like @fjalakyce + '%' or
Mbiemri like @fjalakyce + '%' or
NumriIdentifikues like @fjalakyce + '%' or
Vendlindja like @fjalakyce + '%' or
Vendbanimi like @fjalakyce + '%' or
Adresa like @fjalakyce + '%' or
TelefoniFiks like @fjalakyce + '%' or
TelefoniMobil like @fjalakyce + '%' or
Emaili like @fjalakyce + '%' or
Pseudonimi like @fjalakyce + '%'

GO
/****** Object:  StoredProcedure [dbo].[PerdoruesitAgjensionitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PerdoruesitAgjensionitLexo]

@fjalakyce varchar(50)

as

select * from PerdoruesitAgjensionit where

Emri like @fjalakyce + '%' or
Mbiemri like @fjalakyce + '%' or
NumriIdentifikues like @fjalakyce + '%' or
Vendlindja like @fjalakyce + '%' or
Vendbanimi like @fjalakyce + '%' or
Adresa like @fjalakyce + '%' or
TelefoniFiks like @fjalakyce + '%' or
TelefoniMobil like @fjalakyce + '%' or
Emaili like @fjalakyce + '%' or
Pseudonimi like @fjalakyce + '%'


GO
/****** Object:  StoredProcedure [dbo].[PerdoruesitAgjensionitLexoSipasAgjensionit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PerdoruesitAgjensionitLexoSipasAgjensionit]

@AgjensioniID int

as

select * from PerdoruesitAgjensionit where AgjensioniID = @AgjensioniID
GO
/****** Object:  StoredProcedure [dbo].[QytetetLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetetLexo]

@fjalakyce varchar(50)

as

select * from Qytetet where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[QytetetLexoSipasShtetit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetetLexoSipasShtetit]

@ShtetiID int

as

select * from Qytetet where ShtetiID = @ShtetiID
GO
/****** Object:  StoredProcedure [dbo].[QytetiFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetiFshi]

@ID int

as

delete from Qytetet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[QytetiLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetiLexo]

@ID int

as

select * from Qytetet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[QytetiNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetiNdrysho]

@ID int,
@Emri varchar(50),
@ShtetiID int

as

update Qytetet set

Emri = @Emri,
ShtetiID = @ShtetiID

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[QytetiShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[QytetiShkruaj]

@Emri varchar(50),
@ShtetiID int

as

insert Qytetet values
(
  @Emri,
  @ShtetiID
)

select cast(@@identity as int) as ID
GO
/****** Object:  StoredProcedure [dbo].[RezervimetLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RezervimetLexo]

@fjalakyce varchar(50)

as

select * from Rezervimet where 

UdhetariID in (select ID from Udhetaret where Emri like @fjalakyce + '%')

GO
/****** Object:  StoredProcedure [dbo].[RezervimetLexoSipasAgjensionit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RezervimetLexoSipasAgjensionit]

@AgjensioniID int

as

select * from Rezervimet where 

PerdoruesiAgjensionitID in (select ID from PerdoruesitAgjensionit where AgjensioniID = @AgjensioniID)
GO
/****** Object:  StoredProcedure [dbo].[RezervimiFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RezervimiFshi]

@ID int

as

delete from Rezervimet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[RezervimiLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RezervimiLexo]

@ID int

as

select * from Rezervimet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[RezervimiNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RezervimiNdrysho]

@ID int,
@PerdoruesiAgjensionitID int,
@FluturimiID int,
@UdhetariID int,
@UlesjaID int,
@LlojiRezervimit int,
@Cmimi decimal(18, 2)

as

update Rezervimet set

PerdoruesiAgjensionitID = @PerdoruesiAgjensionitID,
FluturimiID = @FluturimiID,
UdhetariID = @UdhetariID,
UlesjaID = @UlesjaID,
LlojiRezervimit = @LlojiRezervimit,
Cmimi = @Cmimi

where ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[RezervimiShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RezervimiShkruaj]

@PerdoruesiAgjensionitID int,
@FluturimiID int,
@UdhetariID int,
@UlesjaID int,
@LlojiRezervimit int,
@Cmimi decimal(18, 2)

as

insert Rezervimet values
(
  @PerdoruesiAgjensionitID,
  @FluturimiID,
  @UdhetariID,
  @UlesjaID,
  @LlojiRezervimit,
  @Cmimi
)

select cast (@@identity as int) as ID


GO
/****** Object:  StoredProcedure [dbo].[ShtetetLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShtetetLexo]

@fjalakyce varchar(50)

as

select * from Shtetet where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[ShtetiFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShtetiFshi]

@ID int

as

delete from Shtetet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[ShtetiLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShtetiLexo]

@ID int

as

select * from Shtetet where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[ShtetiNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShtetiNdrysho]

@ID int,
@Emri varchar(50)

as

update Shtetet set

Emri = @Emri

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[ShtetiShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShtetiShkruaj]

@Emri varchar(50)

as

insert Shtetet values
(
  @Emri
)

select cast(@@identity as int) as ID
GO
/****** Object:  StoredProcedure [dbo].[TipetAeroplanaveLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TipetAeroplanaveLexo]

@fjalakyce varchar(50)

as

select * from TipetAeroplanave where Emri like @fjalakyce + '%'
GO
/****** Object:  StoredProcedure [dbo].[TipiAeroplanitFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TipiAeroplanitFshi]

@ID int

as

delete from TipetAeroplanave where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[TipiAeroplanitLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TipiAeroplanitLexo]

@ID int

as

select * from TipetAeroplanave where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[TipiAeroplanitNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TipiAeroplanitNdrysho]

@ID int,
@Emri varchar(50)

as

update TipetAeroplanave set

Emri = @Emri

where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[TipiAeroplanitShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TipiAeroplanitShkruaj]

@Emri varchar(50)

as

insert TipetAeroplanave values
(
  @Emri
)

select cast(@@identity as int) as ID

GO
/****** Object:  StoredProcedure [dbo].[UdhetaretLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UdhetaretLexo]

@fjalakyce varchar(50)

as

select * from Udhetaret where

Emri like @fjalakyce + '%' or
Mbiemri like @fjalakyce + '%' or
NumriIdentifikues like @fjalakyce + '%' or
Vendlindja like @fjalakyce + '%' or
Vendbanimi like @fjalakyce + '%' or
Adresa like @fjalakyce + '%' or
TelefoniFiks like @fjalakyce + '%' or
TelefoniMobil like @fjalakyce + '%' or
Emaili like @fjalakyce + '%'


GO
/****** Object:  StoredProcedure [dbo].[UdhetariFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UdhetariFshi]

@ID int

as

delete from Udhetaret where ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[UdhetariLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UdhetariLexo]

@ID int

as

select * from Udhetaret where ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[UdhetariNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UdhetariNdrysho]

@ID int,
@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@PerdoruesiAgjensionitID int

as

update Udhetaret set

Emri = @Emri,
Mbiemri = @Mbiemri,
NumriIdentifikues = @NumriIdentifikues,
DokumentiIdentifikues = @DokumentiIdentifikues,
Datelindja = @Datelindja,
Vendlindja = @Vendlindja,
Vendbanimi = @Vendbanimi,
Adresa = @Adresa,
TelefoniFiks = @TelefoniFiks,
TelefoniMobil = @TelefoniMobil,
Emaili = @Emaili,
PerdoruesiAgjensionitID = @PerdoruesiAgjensionitID

where ID = @ID



GO
/****** Object:  StoredProcedure [dbo].[UdhetariShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UdhetariShkruaj]

@Emri varchar(50),
@Mbiemri varchar(50),
@NumriIdentifikues varchar(50),
@DokumentiIdentifikues int,
@Datelindja datetime,
@Vendlindja varchar(50),
@Vendbanimi varchar(50),
@Adresa varchar(50),
@TelefoniFiks varchar(50),
@TelefoniMobil varchar(50),
@Emaili varchar(50),
@PerdoruesiAgjensionitID int

as

insert Udhetaret values
(
  @Emri,
  @Mbiemri,
  @NumriIdentifikues,
  @DokumentiIdentifikues,
  @Datelindja,
  @Vendlindja,
  @Vendbanimi,
  @Adresa,
  @TelefoniFiks,
  @TelefoniMobil,
  @Emaili,
  @PerdoruesiAgjensionitID
)

select cast(@@identity as int) as ID



GO
/****** Object:  StoredProcedure [dbo].[UlesetFshiSipasAeroplanit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesetFshiSipasAeroplanit]

@AeroplaniID int

as

delete from Uleset where AeroplaniID = @AeroplaniID
GO
/****** Object:  StoredProcedure [dbo].[UlesetLexoSipasAeroplanit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UlesetLexoSipasAeroplanit]

@AeroplaniID int

as

select * from Uleset where AeroplaniID = @AeroplaniID

GO
/****** Object:  StoredProcedure [dbo].[UlesetLexoSipasStatusit]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesetLexoSipasStatusit]

@AeroplaniID int,
@UlesjaEZene int

as

select * from Uleset where AeroplaniID = @AeroplaniID and UlesjaEZene = @UlesjaEZene
GO
/****** Object:  StoredProcedure [dbo].[UlesetLiraLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesetLiraLexo]

@AeroplaniID int,
@UlesjaEZene int

as

select count(*) from Uleset

where AeroplaniID = @AeroplaniID and UlesjaEZene = @UlesjaEZene
GO
/****** Object:  StoredProcedure [dbo].[UlesjaFshi]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesjaFshi]

@ID int

as

delete from Uleset where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[UlesjaLexo]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesjaLexo]

@ID int

as

select * from Uleset where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[UlesjaNdrysho]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesjaNdrysho]

@ID int,
@Numri int,
@AeroplaniID int,
@UlesjaEZene int

as

update Uleset set

Numri = @Numri,
AeroplaniID = @AeroplaniID,
UlesjaEZene = @UlesjaEZene

where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[UlesjaShkruaj]    Script Date: 7/16/2016 8:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UlesjaShkruaj]

@Numri int,
@AeroplaniID int,
@UlesjaEZene int

as

insert Uleset values
(
  @Numri,
  @AeroplaniID,
  @UlesjaEZene
)

select cast(@@identity as int) as ID
GO
