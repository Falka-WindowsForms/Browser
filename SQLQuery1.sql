create table Categories (
 [Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
 [Name] nvarchar(50) NOT NULL UNIQUE
);
go


create table Sites (
[Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
[Name] nvarchar(50) NOT NULL UNIQUE,
[Addr] nvarchar(256) NOT NULL UNIQUE,
[CategoryId] int NOT NULL foreign key references Categories([Id]) on delete cascade
);
go


insert into [Categories]([Name]) values
(N'News sites'),
(N'Search systems'),
(N'Files'),
(N'Sport sites'),
(N'Game portals'),
(N'Social media')

insert into Sites([Name],[Addr],[CategoryId])values
(N'Google news',N'https://news.google.com',1),
(N'CNN news',N'https://edition.cnn.com',1),
(N'Videos news',N'https://bing.com/videos',1),
(N'Bing search',N'https://bing.com',2),
(N'Yahoo search',N'https://yahoo.com',2),
(N'Instagram',N'https://instagram.com',6)