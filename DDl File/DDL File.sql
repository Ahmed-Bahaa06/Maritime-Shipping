if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CARRIES') and o.name = 'FK_CARRIES_CARRIES_VOYAGE')
alter table CARRIES
   drop constraint FK_CARRIES_CARRIES_VOYAGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CARRIES') and o.name = 'FK_CARRIES_CARRIES2_CONTAINE')
alter table CARRIES
   drop constraint FK_CARRIES_CARRIES2_CONTAINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTAINER') and o.name = 'FK_CONTAINE_OWNS_CLIENT')
alter table CONTAINER
   drop constraint FK_CONTAINE_OWNS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS') and o.name = 'FK_HAS_HAS_VOYAGE')
alter table HAS
   drop constraint FK_HAS_HAS_VOYAGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS') and o.name = 'FK_HAS_HAS2_CREWMEMB')
alter table HAS
   drop constraint FK_HAS_HAS2_CREWMEMB
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTS_IN') and o.name = 'FK_LISTS_IN_LISTS_IN_MANIFEST')
alter table LISTS_IN
   drop constraint FK_LISTS_IN_LISTS_IN_MANIFEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTS_IN') and o.name = 'FK_LISTS_IN_LISTS_IN2_CONTAINE')
alter table LISTS_IN
   drop constraint FK_LISTS_IN_LISTS_IN2_CONTAINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANIFEST') and o.name = 'FK_MANIFEST_REFERENCE_VOYAGE')
alter table MANIFEST
   drop constraint FK_MANIFEST_REFERENCE_VOYAGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VOYAGE') and o.name = 'FK_VOYAGE_ARRIVES_A_PORT')
alter table VOYAGE
   drop constraint FK_VOYAGE_ARRIVES_A_PORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VOYAGE') and o.name = 'FK_VOYAGE_DEPARTS_F_PORT')
alter table VOYAGE
   drop constraint FK_VOYAGE_DEPARTS_F_PORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VOYAGE') and o.name = 'FK_VOYAGE_OPERATES_VESSEL')
alter table VOYAGE
   drop constraint FK_VOYAGE_OPERATES_VESSEL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CARRIES')
            and   name  = 'CARRIES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CARRIES.CARRIES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CARRIES')
            and   name  = 'CARRIES_FK'
            and   indid > 0
            and   indid < 255)
   drop index CARRIES.CARRIES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CARRIES')
            and   type = 'U')
   drop table CARRIES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTAINER')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTAINER.OWNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONTAINER')
            and   type = 'U')
   drop table CONTAINER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CREWMEMBER')
            and   type = 'U')
   drop table CREWMEMBER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS.HAS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HAS')
            and   type = 'U')
   drop table HAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LISTS_IN')
            and   name  = 'LISTS_IN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index LISTS_IN.LISTS_IN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LISTS_IN')
            and   name  = 'LISTS_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index LISTS_IN.LISTS_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTS_IN')
            and   type = 'U')
   drop table LISTS_IN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANIFEST')
            and   name  = 'CONTAINS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANIFEST.CONTAINS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANIFEST')
            and   type = 'U')
   drop table MANIFEST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PORT')
            and   type = 'U')
   drop table PORT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VESSEL')
            and   type = 'U')
   drop table VESSEL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VOYAGE')
            and   name  = 'CONTAINS_FK'
            and   indid > 0
            and   indid < 255)
   drop index VOYAGE.CONTAINS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VOYAGE')
            and   name  = 'ARRIVES_AT_FK'
            and   indid > 0
            and   indid < 255)
   drop index VOYAGE.ARRIVES_AT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VOYAGE')
            and   name  = 'DEPARTS_FROM_FK'
            and   indid > 0
            and   indid < 255)
   drop index VOYAGE.DEPARTS_FROM_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VOYAGE')
            and   name  = 'OPERATES_FK'
            and   indid > 0
            and   indid < 255)
   drop index VOYAGE.OPERATES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VOYAGE')
            and   type = 'U')
   drop table VOYAGE
go

/*==============================================================*/
/* Table: CARRIES                                               */
/*==============================================================*/
create table CARRIES (
   VOYAGE_ID            int                  not null,
   SERIAL_NUMBER        varchar(20)          not null,
   constraint PK_CARRIES primary key (VOYAGE_ID, SERIAL_NUMBER)
)
go

/*==============================================================*/
/* Index: CARRIES_FK                                            */
/*==============================================================*/




create nonclustered index CARRIES_FK on CARRIES (VOYAGE_ID ASC)
go

/*==============================================================*/
/* Index: CARRIES2_FK                                           */
/*==============================================================*/




create nonclustered index CARRIES2_FK on CARRIES (SERIAL_NUMBER ASC)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            int                  not null,
   CLIENT_NAME          varchar(100)         not null,
   CONTACT_INFO         varchar(255)         null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Table: CONTAINER                                             */
/*==============================================================*/
create table CONTAINER (
   SERIAL_NUMBER        varchar(20)          not null,
   CLIENT_ID            int                  not null,
   SIZE                 varchar(10)          not null,
   CARGO_TYPE           varchar(30)          not null,
   constraint PK_CONTAINER primary key (SERIAL_NUMBER)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/




create nonclustered index OWNS_FK on CONTAINER (CLIENT_ID ASC)
go

/*==============================================================*/
/* Table: CREWMEMBER                                            */
/*==============================================================*/
create table CREWMEMBER (
   CREW_ID              int                  not null,
   CREW_NAME            varchar(100)         not null,
   NATIONALITY          varchar(50)          null,
   constraint PK_CREWMEMBER primary key (CREW_ID)
)
go

/*==============================================================*/
/* Table: HAS                                                   */
/*==============================================================*/
create table HAS (
   VOYAGE_ID            int                  not null,
   CREW_ID              int                  not null,
   ROLE                 varchar(20)          null,
   constraint PK_HAS primary key (VOYAGE_ID, CREW_ID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on HAS (VOYAGE_ID ASC)
go

/*==============================================================*/
/* Index: HAS2_FK                                               */
/*==============================================================*/




create nonclustered index HAS2_FK on HAS (CREW_ID ASC)
go

/*==============================================================*/
/* Table: LISTS_IN                                              */
/*==============================================================*/
create table LISTS_IN (
   MANIFEST_ID          int                  not null,
   SERIAL_NUMBER        varchar(20)          not null,
   constraint PK_LISTS_IN primary key (MANIFEST_ID, SERIAL_NUMBER)
)
go

/*==============================================================*/
/* Index: LISTS_IN_FK                                           */
/*==============================================================*/




create nonclustered index LISTS_IN_FK on LISTS_IN (MANIFEST_ID ASC)
go

/*==============================================================*/
/* Index: LISTS_IN2_FK                                          */
/*==============================================================*/




create nonclustered index LISTS_IN2_FK on LISTS_IN (SERIAL_NUMBER ASC)
go

/*==============================================================*/
/* Table: MANIFEST                                              */
/*==============================================================*/
create table MANIFEST (
   MANIFEST_ID          int                  not null,
   VOYAGE_ID            int                  null,
   MANIFEST_DATE        datetime             not null,
   constraint PK_MANIFEST primary key (MANIFEST_ID)
)
go

/*==============================================================*/
/* Index: CONTAINS2_FK                                          */
/*==============================================================*/




create nonclustered index CONTAINS2_FK on MANIFEST (VOYAGE_ID ASC)
go

/*==============================================================*/
/* Table: PORT                                                  */
/*==============================================================*/
create table PORT (
   PORT_ID              int                  not null,
   PORT_NAME            varchar(100)         not null,
   COORDINATES          varchar(50)          null,
   DOCKING_FEES         numeric(8,2)         not null,
   CITY                 varchar(50)          not null,
   COUNTRY              varchar(50)          not null,
   TERMINAL_AREA        varchar(50)          null,
   constraint PK_PORT primary key (PORT_ID)
)
go

/*==============================================================*/
/* Table: VESSEL                                                */
/*==============================================================*/
create table VESSEL (
   VESSEL_ID            int                  not null,
   CAPACITY             int                  not null,
   REGISTRATION         varchar(50)          not null,
   FUEL_EFFICIENCY_RATING decimal(5,2)         null,
   constraint PK_VESSEL primary key (VESSEL_ID)
)
go

/*==============================================================*/
/* Table: VOYAGE                                                */
/*==============================================================*/
create table VOYAGE (
   VOYAGE_ID            int                  not null,
   ORIGIN_PORT_ID       int                  not null,
   DEST_PORT_ID         int                  not null,
   VESSEL_ID            int                  not null,
   STATUS               varchar(20)          not null,
   DEPARTURE_DATE       datetime             not null,
   ARRIVAL_DATE         datetime             not null,
   constraint PK_VOYAGE primary key (VOYAGE_ID)
)
go

/*==============================================================*/
/* Index: OPERATES_FK                                           */
/*==============================================================*/




create nonclustered index OPERATES_FK on VOYAGE (VESSEL_ID ASC)
go

/*==============================================================*/
/* Index: DEPARTS_FROM_FK                                       */
/*==============================================================*/




create nonclustered index DEPARTS_FROM_FK on VOYAGE (ORIGIN_PORT_ID ASC)
go

/*==============================================================*/
/* Index: ARRIVES_AT_FK                                         */
/*==============================================================*/




create nonclustered index ARRIVES_AT_FK on VOYAGE (DEST_PORT_ID ASC)
go

/*==============================================================*/
/* Index: CONTAINS_FK                                           */
/*==============================================================*/




create nonclustered index CONTAINS_FK on VOYAGE (VESSEL_ID ASC)
go

alter table CARRIES
   add constraint FK_CARRIES_CARRIES_VOYAGE foreign key (VOYAGE_ID)
      references VOYAGE (VOYAGE_ID)
go

alter table CARRIES
   add constraint FK_CARRIES_CARRIES2_CONTAINE foreign key (SERIAL_NUMBER)
      references CONTAINER (SERIAL_NUMBER)
go

alter table CONTAINER
   add constraint FK_CONTAINE_OWNS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table HAS
   add constraint FK_HAS_HAS_VOYAGE foreign key (VOYAGE_ID)
      references VOYAGE (VOYAGE_ID)
go

alter table HAS
   add constraint FK_HAS_HAS2_CREWMEMB foreign key (CREW_ID)
      references CREWMEMBER (CREW_ID)
go

alter table LISTS_IN
   add constraint FK_LISTS_IN_LISTS_IN_MANIFEST foreign key (MANIFEST_ID)
      references MANIFEST (MANIFEST_ID)
go

alter table LISTS_IN
   add constraint FK_LISTS_IN_LISTS_IN2_CONTAINE foreign key (SERIAL_NUMBER)
      references CONTAINER (SERIAL_NUMBER)
go

alter table MANIFEST
   add constraint FK_MANIFEST_REFERENCE_VOYAGE foreign key (VOYAGE_ID)
      references VOYAGE (VOYAGE_ID)
go

alter table VOYAGE
   add constraint FK_VOYAGE_ARRIVES_A_PORT foreign key (DEST_PORT_ID)
      references PORT (PORT_ID)
go

alter table VOYAGE
   add constraint FK_VOYAGE_DEPARTS_F_PORT foreign key (ORIGIN_PORT_ID)
      references PORT (PORT_ID)
go

alter table VOYAGE
   add constraint FK_VOYAGE_OPERATES_VESSEL foreign key (VESSEL_ID)
      references VESSEL (VESSEL_ID)
go



-- =======================================================================
/*                          Populated Data */
-- =======================================================================



-- =====================================================
-- MARITIME SHIPPING DATABASE - SAMPLE DATA
-- =====================================================

-- =====================================================
/* Insert CLIENT Data */
-- =====================================================
INSERT INTO CLIENT (CLIENT_ID, CLIENT_NAME, CONTACT_INFO) VALUES
(1, 'Global Trade Solutions Inc', 'contact@globaltrade.com | +1-212-555-0101'),
(2, 'Ocean Freight Logistics', 'info@oceanfreight.com | +44-20-7946-0958'),
(3, 'Asia Pacific Shipping Corp', 'sales@apshipcorp.com | +65-6500-1234'),
(4, 'European Container Services', 'support@eucontainers.eu | +49-40-3610-5555'),
(5, 'Middle East Trade Partners', 'business@metradepart.ae | +971-4-308-3333'),
(6, 'North American Logistics Ltd', 'logistics@nalogistics.com | +1-514-555-0102'),
(7, 'South African Import Export', 'trade@saimpex.co.za | +27-11-555-0103'),
(8, 'Australian Cargo Worldwide', 'cargo@auscargoworld.com.au | +61-2-555-0104')
go

-- =====================================================
/* Insert PORT Data */
-- =====================================================
INSERT INTO PORT (PORT_ID, PORT_NAME, COORDINATES, DOCKING_FEES, CITY, COUNTRY, TERMINAL_AREA) VALUES
(1, 'Port of Singapore', '1.2553°N, 103.8677°E', 5500.00, 'Singapore', 'Singapore', 'Pasir Panjang Terminal'),
(2, 'Port of Rotterdam', '51.9544°N, 4.0403°E', 4200.00, 'Rotterdam', 'Netherlands', 'APM Terminals'),
(3, 'Port of Dubai', '25.2048°N, 55.2708°E', 6800.00, 'Dubai', 'UAE', 'Jebel Ali Terminal'),
(4, 'Port of Shanghai', '30.9327°N, 121.6357°E', 4800.00, 'Shanghai', 'China', 'Yangshan Deep Water Port'),
(5, 'Port of Los Angeles', '33.7426°N, 118.2413°W', 5200.00, 'Los Angeles', 'USA', 'TraPac Terminal'),
(6, 'Port of Hamburg', '53.5511°N, 9.9605°E', 4100.00, 'Hamburg', 'Germany', 'Burchardkai Terminal'),
(7, 'Port of Hong Kong', '22.3193°N, 114.1694°E', 5900.00, 'Hong Kong', 'China', 'Kwai Tsing Container Terminal'),
(8, 'Port of Antwerp', '51.3383°N, 4.2764°E', 3900.00, 'Antwerp', 'Belgium', 'APL Terminal'),
(9, 'Port of Busan', '35.0395°N, 129.0189°E', 4600.00, 'Busan', 'South Korea', 'New Port Terminal'),
(10, 'Port of Barcelona', '41.3851°N, 2.1734°E', 3700.00, 'Barcelona', 'Spain', 'Port Vell Terminal')
go

-- =====================================================
/* Insert VESSEL Data */
-- =====================================================
INSERT INTO VESSEL (VESSEL_ID, CAPACITY, REGISTRATION, FUEL_EFFICIENCY_RATING) VALUES
(1, 20000, 'SG-2021-001', 8.5),
(2, 18000, 'NL-2020-002', 8.2),
(3, 22000, 'AE-2022-003', 8.8),
(4, 19000, 'CN-2019-004', 7.9),
(5, 21000, 'US-2021-005', 8.6),
(6, 17000, 'DE-2020-006', 8.1),
(7, 23000, 'HK-2022-007', 8.9),
(8, 16000, 'BE-2021-008', 7.8)
go

-- =====================================================
/* Insert VOYAGE Data */
-- =====================================================
INSERT INTO VOYAGE (VOYAGE_ID, ORIGIN_PORT_ID, DEST_PORT_ID, VESSEL_ID, STATUS, DEPARTURE_DATE, ARRIVAL_DATE) VALUES
(1, 1, 5, 1, 'IN_TRANSIT', '2026-05-01 08:00:00', '2026-05-22 16:00:00'),
(2, 2, 7, 2, 'COMPLETED', '2026-04-15 10:00:00', '2026-05-02 14:00:00'),
(3, 3, 6, 3, 'IN_TRANSIT', '2026-05-05 12:00:00', '2026-05-18 18:00:00'),
(4, 4, 2, 4, 'IN_TRANSIT', '2026-04-28 06:00:00', '2026-05-19 20:00:00'),
(5, 5, 9, 5, 'PLANNED', '2026-05-15 14:00:00', '2026-06-05 10:00:00'),
(6, 6, 3, 6, 'COMPLETED', '2026-04-20 09:00:00', '2026-05-08 11:00:00'),
(7, 7, 8, 7, 'IN_TRANSIT', '2026-05-03 15:00:00', '2026-05-21 12:00:00'),
(8, 9, 1, 8, 'COMPLETED', '2026-04-25 11:00:00', '2026-05-10 17:00:00')
go

-- =====================================================
/* Insert CONTAINER Data */
-- =====================================================
INSERT INTO CONTAINER (SERIAL_NUMBER, CLIENT_ID, SIZE, CARGO_TYPE) VALUES
('CONT-001-20FT', 1, '20ft', 'Electronics'),
('CONT-002-40FT', 2, '40ft', 'Textiles'),
('CONT-003-20FT', 3, '20ft', 'Machinery'),
('CONT-004-40FT', 4, '40ft', 'Chemicals'),
('CONT-005-20FT', 5, '20ft', 'Automotive Parts'),
('CONT-006-40FT', 6, '40ft', 'Raw Materials'),
('CONT-007-20FT', 7, '20ft', 'Consumer Goods'),
('CONT-008-40FT', 8, '40ft', 'Industrial Equipment'),
('CONT-009-20FT', 1, '20ft', 'Pharmaceuticals'),
('CONT-010-40FT', 2, '40ft', 'Perishables'),
('CONT-011-20FT', 3, '20ft', 'Furniture'),
('CONT-012-40FT', 4, '40ft', 'Steel Products'),
('CONT-013-20FT', 5, '20ft', 'Electronics'),
('CONT-014-40FT', 6, '40ft', 'Grain'),
('CONT-015-20FT', 7, '20ft', 'Plastics'),
('CONT-016-40FT', 8, '40ft', 'Metal Ore')
go

-- =====================================================
/* Insert CREWMEMBER Data */
-- =====================================================
INSERT INTO CREWMEMBER (CREW_ID, CREW_NAME, NATIONALITY) VALUES
(1, 'Captain James Anderson', 'British'),
(2, 'First Officer Maria Garcia', 'Spanish'),
(3, 'Chief Engineer Liu Chen', 'Chinese'),
(4, 'Second Engineer Raj Patel', 'Indian'),
(5, 'Bosun Ole Andersen', 'Norwegian'),
(6, 'Able Seaman Pedro Silva', 'Portuguese'),
(7, 'Deck Officer Yuki Tanaka', 'Japanese'),
(8, 'Deckhand Dmitri Volkov', 'Russian'),
(9, 'Chief Steward Sophie Martin', 'French'),
(10, 'Cook Wolfgang Fischer', 'German'),
(11, 'Electrician Hans Mueller', 'Austrian'),
(12, 'Carpenter Kim Park', 'Korean'),
(13, 'Captain Sarah Mitchell', 'American'),
(14, 'First Officer Marco Rossi', 'Italian'),
(15, 'Chief Engineer Ahmed Hassan', 'Egyptian')
go

-- =====================================================
/* Insert MANIFEST Data */
-- =====================================================
INSERT INTO MANIFEST (MANIFEST_ID, VOYAGE_ID, MANIFEST_DATE) VALUES
(1, 1, '2026-05-01 08:30:00'),
(2, 2, '2026-04-15 10:30:00'),
(3, 3, '2026-05-05 12:30:00'),
(4, 4, '2026-04-28 06:30:00'),
(5, 5, '2026-05-15 14:30:00'),
(6, 6, '2026-04-20 09:30:00'),
(7, 7, '2026-05-03 15:30:00'),
(8, 8, '2026-04-25 11:30:00')
go

-- =====================================================
/* Insert CARRIES Data (Voyage-Container Relationship) */
-- =====================================================
INSERT INTO CARRIES (VOYAGE_ID, SERIAL_NUMBER) VALUES
(1, 'CONT-001-20FT'),
(1, 'CONT-002-40FT'),
(1, 'CONT-003-20FT'),
(2, 'CONT-004-40FT'),
(2, 'CONT-005-20FT'),
(2, 'CONT-006-40FT'),
(3, 'CONT-007-20FT'),
(3, 'CONT-008-40FT'),
(4, 'CONT-009-20FT'),
(4, 'CONT-010-40FT'),
(5, 'CONT-011-20FT'),
(5, 'CONT-012-40FT'),
(5, 'CONT-013-20FT'),
(6, 'CONT-014-40FT'),
(6, 'CONT-015-20FT'),
(7, 'CONT-016-40FT'),
(7, 'CONT-001-20FT'),
(8, 'CONT-002-40FT'),
(8, 'CONT-003-20FT')
go

-- =====================================================
/* Insert LISTS_IN Data (Manifest-Container Relationship) */
-- =====================================================
INSERT INTO LISTS_IN (MANIFEST_ID, SERIAL_NUMBER) VALUES
(1, 'CONT-001-20FT'),
(1, 'CONT-002-40FT'),
(1, 'CONT-003-20FT'),
(2, 'CONT-004-40FT'),
(2, 'CONT-005-20FT'),
(2, 'CONT-006-40FT'),
(3, 'CONT-007-20FT'),
(3, 'CONT-008-40FT'),
(4, 'CONT-009-20FT'),
(4, 'CONT-010-40FT'),
(5, 'CONT-011-20FT'),
(5, 'CONT-012-40FT'),
(5, 'CONT-013-20FT'),
(6, 'CONT-014-40FT'),
(6, 'CONT-015-20FT'),
(7, 'CONT-016-40FT'),
(7, 'CONT-001-20FT'),
(8, 'CONT-002-40FT'),
(8, 'CONT-003-20FT')
go

-- =====================================================
/* Insert HAS Data (Voyage-Crew Member Relationship) */
-- =====================================================
INSERT INTO HAS (VOYAGE_ID, CREW_ID, ROLE) VALUES
(1, 1, 'Captain'),
(1, 2, 'First Officer'),
(1, 3, 'Chief Engineer'),
(1, 4, 'Second Engineer'),
(1, 5, 'Bosun'),
(1, 6, 'Able Seaman'),
(2, 1, 'Captain'),
(2, 2, 'First Officer'),
(2, 3, 'Chief Engineer'),
(2, 7, 'Deck Officer'),
(2, 8, 'Deckhand'),
(3, 13, 'Captain'),
(3, 14, 'First Officer'),
(3, 15, 'Chief Engineer'),
(3, 5, 'Bosun'),
(3, 9, 'Chief Steward'),
(4, 1, 'Captain'),
(4, 2, 'First Officer'),
(4, 10, 'Cook'),
(4, 11, 'Electrician'),
(5, 13, 'Captain'),
(5, 14, 'First Officer'),
(5, 15, 'Chief Engineer'),
(5, 12, 'Carpenter'),
(6, 1, 'Captain'),
(6, 3, 'Chief Engineer'),
(6, 6, 'Able Seaman'),
(7, 13, 'Captain'),
(7, 2, 'First Officer'),
(7, 4, 'Second Engineer'),
(8, 1, 'Captain'),
(8, 5, 'Bosun'),
(8, 9, 'Chief Steward')
go

-- =====================================================
/* VERIFICATION QUERIES */
-- =====================================================
-- Verify data was inserted correctly
SELECT 'CLIENT' as TableName, COUNT(*) as RecordCount FROM CLIENT
UNION ALL
SELECT 'PORT', COUNT(*) FROM PORT
UNION ALL
SELECT 'VESSEL', COUNT(*) FROM VESSEL
UNION ALL
SELECT 'VOYAGE', COUNT(*) FROM VOYAGE
UNION ALL
SELECT 'CONTAINER', COUNT(*) FROM CONTAINER
UNION ALL
SELECT 'CREWMEMBER', COUNT(*) FROM CREWMEMBER
UNION ALL
SELECT 'MANIFEST', COUNT(*) FROM MANIFEST
UNION ALL
SELECT 'CARRIES', COUNT(*) FROM CARRIES
UNION ALL
SELECT 'LISTS_IN', COUNT(*) FROM LISTS_IN
UNION ALL
SELECT 'HAS', COUNT(*) FROM HAS
go