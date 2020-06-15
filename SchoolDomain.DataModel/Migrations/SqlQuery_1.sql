﻿CREATE TABLE [dbo].[Courses] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [NumberOfStudents] [int] NOT NULL,
    [SchoolId] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Courses] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_SchoolId] ON [dbo].[Courses]([SchoolId])
CREATE TABLE [dbo].[Schools] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Address] [nvarchar](max),
    [NumberOfCourses] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Schools] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Subjects] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Area] [nvarchar](max),
    [CourseId] [int] NOT NULL,
    [Student_Id] [int],
    CONSTRAINT [PK_dbo.Subjects] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_CourseId] ON [dbo].[Subjects]([CourseId])
CREATE INDEX [IX_Student_Id] ON [dbo].[Subjects]([Student_Id])
CREATE TABLE [dbo].[Students] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Address] [nvarchar](max),
    [Age] [int] NOT NULL,
    [CourseId] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_CourseId] ON [dbo].[Students]([CourseId])
ALTER TABLE [dbo].[Courses] ADD CONSTRAINT [FK_dbo.Courses_dbo.Schools_SchoolId] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[Schools] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Subjects] ADD CONSTRAINT [FK_dbo.Subjects_dbo.Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Subjects] ADD CONSTRAINT [FK_dbo.Subjects_dbo.Students_Student_Id] FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Students] ([Id])
ALTER TABLE [dbo].[Students] ADD CONSTRAINT [FK_dbo.Students_dbo.Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]) ON DELETE CASCADE
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202006141947295_Initial', N'SchoolDomain.DataModel.Migrations.Configuration',  0x1F8B0800000000000400ED5CDB6EE336107D2FD07F10F4D416592BC9BEB481BD8BD4498AA09B0BE264D1B78096C68E5A8A72452A7050F4CBFAD04FEA2F94BA909678D1C5711C07080A6C3722399C199EB99033D9FFFEF977F8791961E711121AC664E41E0CF65D07881F0721998FDC94CD3EFCE87EFEF4ED37C3D3205A3A5FC5BC8FD93CBE92D091FBC0D8E2C8F3A8FF0011A28328F49398C63336F0E3C84341EC1DEEEFFFE41D1C78C049B89C96E30C6F52C2C208F21FF88FE398F8B06029C21771009896DFF9C824A7EA5CA208E802F93072F99738C6277184423238410CE54B5CE71887887333013C731D4448CC10E3BC1EDD5198B02426F3C9827F40F8F669017CDE0C610AA50C47ABE95DC5D93FCCC4F1560B05293FA58CF3D68FE0C1C7523F9EBA7C2D2DBB527F5C83A75CD3EC29933AD7E2C81DC7699289AE6E7534C649364D51F118234A810E8A657B8E69704F22830328FB6FCF19A798A5098C08A42C4178CFB94EA738F47F85A7DBF80F202392625CE59373CAC76A1FF8A7EB245E40C29E6E6056727F1EB88E575FE7A90BE5B2CA9A42B273C23E1EBACE25DF1C4D31481854B430617102BF0081043108AE116390908C06E48AD47657F6CAFE14BB71DC7133729D0BB4FC0264CE1E462EFFABEB9C854B08C49792833B1272ABE38B589242EB26693485E46A366169C6166D13AF995A71A2ED4A52A85CA2C7709EEBCC48CF756E00E7C3F4215C1486392886EE0B2C71B6CF9238BA89B15C2446EE6F513207C6398A8DC313FE7FBF0F4BE9F477F0334599982A06EF85615498AA8DE84CD5874D4C0DBD95FD355AA5505A4FAB2C3EBE5BE52E58E571102440E9D6AC5F5AD166CC56927B8EDD0A1BB0D8ADB0A0F54CA430B7FE3652AC7B37929D309204D08B6F52C06D73114D4486E7040FCD32CCB1653DCB28F280FE9651AC7BB78C9DB08C2D858FE3393C2F5FDCA67515003559576D44B7AEFAB0C9BABAE48BA724893186A091397DB2CEA63AC7CAB036B18F6338A634F6C39CCF5A5A2903775DFC531238CD51BC40E22A03E070E42E205C70A3E7DB8FDC035735EE2B7202181838C77E71FD1D23EAA34087031721E8C88ECCBB57EC0840D4D9F941DB85FB184832234778CC0F8F7BAD9030DD2185C40F1708376A4359D5D19165924AFAEAC8092C8064C7DE2877978D5777387D7BB98B72006DBA197A153CB5C0AC1E05ADE76A09891598891CAFED60AD443B8365A3D85D0F6746CEB78133E33974D978E5FB5F0767F578608584253854702632A61E38338794B7803323E7DBC099F11CDE10CEB4D0DE060E7B9C6FC5DEFE6070D0017ED604A1B717B5EAA3482EB80E19D72024B5107332CDBEC3D274D9B8A350DE3768998AAAC2647427C0D417875536A35892A68D3A818225130191AEB41190EF823A05A1C33612F20D5627210E5A215151BB2ACBEA89A532C9FC08A3DA456B362739AF284EB3AED624AC4245F2AABAADBA805D84576ED106E11B328C2E3946557879E84DD29BB38A97915EB9E518A46F887B5D225F557A89D726E9CDB1EE45A5D7AF51763D34FBE57E9E795DDD581D7107A835A849DCEDA4FB5D1543BDA21A2AAAA69EA56C3ABC408B4548E695326AF9C5991435D4F18749FFC26254D0F07C6AA82F4A6EE54E2C4ED01C94D10C37019C85096559E9768A32B88F83489BA6061B8B0F16BBD5E3897E76C2318BF9D9DF6B514D29270FCC86B6D2E419172ECA129DFC6549B30B7D615ECB4618258667AC718CD388D8332EFBEAE261AABABEF8D28382564AAC51D346BB535E5D49AB14ED17D50CD18A76B5D44F3B492D5FAE03A3136C4430DC006CCAB4A33F6C6C0B771536F2B1B24A447EEC0F3F194E4CE8B3C49AD7848CF0EB9BC04C9968AE011ADBCA9D454D5EFCA94126FFD29DC2EA5E58A562BF2DBE1E4284C7DC0442CA7BC41A08B1ADDC59846CC8AFE4458E1A8D792F3E760F67F584D10836430ADD155B86A51DBD4D9619AB91BF25E5D675D7098B82ACF955A8C2C63338B4BE8DAD6D2D8D9CF1F43608F377A7739AD5CF64EDAC9BDCEA3542078E769B50A748D8CA5B85727B1896997C7B67A696DA17535C874BFF1806795AFF44194439FC06933FF11887F9FB88987081483803CA8A6AB27BB87F70A83476EE4E93A54769800D3721BDD3B27E645B288887994E5B4BDE3DABBED51A38794489FF8092EF22B4FCBE4AE939CD8B39D7CF6C5D0C8D4D10E72480E5C8FD2B5F74E49CFF762FD6ED395709C7DD91B3EFFCDDB279DF4EBEF7536FEA6ED808829406B87600F56E357B3F446BF3D6B308A92D245DED56ACEB61B706A75189A73DDD865C69634017BE7713D73BE65ECC71545A9FD689365B44ED0B75F8BC5E4B8FA86D6CB787671B456EEB53F15BEDD2E97C542FD5FD252AAFEBF405AD05961E47B899CE9BB7D403B1EB681145F675BA7B761D2DD687BF9D454BDF8E994D74C66CDD5FF439972D3A8CE607B28D83C0DC26A417782DEFE54AF7B7B507A878451AB9C134E6475C644CB6EE03738350437F9089B8A539C6D63CD4D43B64246FEB09B0741635351619E95B6AB55B6A3B32F41935B653D4CFBF5A43DFA9B6A2CE6C9A5D93E11D7DA7FA86D614AF8ED05AC9E9AD34067561FE05CEB4479B8FFE00CF9D76E51F50E0318386F31589ACAA40C0AFB96B39E79CCC621139148EC414E5D67B010C05DC971F272C9C219FF1619F5FC8F35F4EFA8A70CAA79C465308CEC955CA1629E3224334C5B55FAACAA24FD3FE792F539DE7E1D522FF7D9B4D88C0D90CB90870457E4E431C48BECF0C176F0B892CAC95CF23D959B2EC9964FE24295DC6A423A1527D321ADF42B4C09C18BD2213F408EBF07647E10BCC91FF24EA287622ED075157FBF02444F30445B4A4B15ACF7FE4180EA2E5A7FF01DAB2FBEE47440000 , N'6.4.4')
