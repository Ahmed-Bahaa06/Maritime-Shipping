using System;
using System.Data;
using System.Data.SqlClient;

namespace MaritimeShippingManagementSystem
{
    public class DatabaseManager
    {
        private const string CONNECTION_STRING =
            "Server=AhmedBahaa\\SQLEXPRESS;Database=Maritime Shipping;Integrated Security=True;";

        // ========================= INSERT METHODS =========================

        /// <summary>
        /// Insert Client
        /// </summary>
        public void InsertClient(int id, string name, string contact)
        {
            ExecuteNonQuery(
                "INSERT INTO CLIENT VALUES (@ID,@NAME,@CONTACT)",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", name),
                new SqlParameter("@CONTACT", contact)
            );
        }

        /// <summary>
        /// Insert Port
        /// </summary>
        public void InsertPort(int id, string name, string coords, decimal fee,
                               string city, string country, string terminal)
        {
            ExecuteNonQuery(
                @"INSERT INTO PORT 
                  VALUES (@ID,@NAME,@COORDS,@FEE,@CITY,@COUNTRY,@TERMINAL)",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", name),
                new SqlParameter("@COORDS", coords),
                new SqlParameter("@FEE", fee),
                new SqlParameter("@CITY", city),
                new SqlParameter("@COUNTRY", country),
                new SqlParameter("@TERMINAL", terminal)
            );
        }

        /// <summary>
        /// Insert Vessel
        /// </summary>
        public void InsertVessel(int id, int capacity, string registration,
                                 decimal fuelRating)
        {
            ExecuteNonQuery(
                @"INSERT INTO VESSEL 
                  VALUES (@ID,@CAPACITY,@REG,@FUEL)",
                new SqlParameter("@ID", id),
                new SqlParameter("@CAPACITY", capacity),
                new SqlParameter("@REG", registration),
                new SqlParameter("@FUEL", fuelRating)
            );
        }

        /// <summary>
        /// Insert Voyage
        /// </summary>
        public void InsertVoyage(int id, int originPortId, int destPortId,
                                 int vesselId, string status,
                                 DateTime departure, DateTime arrival)
        {
            ExecuteNonQuery(
                @"INSERT INTO VOYAGE
                  VALUES (@ID,@ORIGIN,@DEST,@VESSEL,@STATUS,@DEP,@ARR)",
                new SqlParameter("@ID", id),
                new SqlParameter("@ORIGIN", originPortId),
                new SqlParameter("@DEST", destPortId),
                new SqlParameter("@VESSEL", vesselId),
                new SqlParameter("@STATUS", status),
                new SqlParameter("@DEP", departure),
                new SqlParameter("@ARR", arrival)
            );
        }

        /// <summary>
        /// Insert Container
        /// </summary>
        public void InsertContainer(string serial, int clientId,
                                    string size, string cargoType)
        {
            ExecuteNonQuery(
                @"INSERT INTO CONTAINER
                  VALUES (@SERIAL,@CLIENT,@SIZE,@CARGO)",
                new SqlParameter("@SERIAL", serial),
                new SqlParameter("@CLIENT", clientId),
                new SqlParameter("@SIZE", size),
                new SqlParameter("@CARGO", cargoType)
            );
        }

        /// <summary>
        /// Insert Crew Member
        /// </summary>
        public void InsertCrewMember(int id, string name, string nationality)
        {
            ExecuteNonQuery(
                @"INSERT INTO CREWMEMBER
                  VALUES (@ID,@NAME,@NATIONALITY)",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", name),
                new SqlParameter("@NATIONALITY", nationality)
            );
        }

        /// <summary>
        /// Insert Manifest
        /// </summary>
        public void InsertManifest(int id, int voyageId, DateTime date)
        {
            ExecuteNonQuery(
                @"INSERT INTO MANIFEST
                  VALUES (@ID,@VOYAGE,@DATE)",
                new SqlParameter("@ID", id),
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@DATE", date)
            );
        }

        /// <summary>
        /// Insert Carries
        /// </summary>
        public void InsertCarries(int voyageId, string serial)
        {
            ExecuteNonQuery(
                @"INSERT INTO CARRIES
                  VALUES (@VOYAGE,@SERIAL)",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Insert Lists In
        /// </summary>
        public void InsertListsIn(int manifestId, string serial)
        {
            ExecuteNonQuery(
                @"INSERT INTO LISTS_IN
                  VALUES (@MANIFEST,@SERIAL)",
                new SqlParameter("@MANIFEST", manifestId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Insert Has
        /// </summary>
        public void InsertHas(int voyageId, int crewId, string role)
        {
            ExecuteNonQuery(
                @"INSERT INTO HAS
                  VALUES (@VOYAGE,@CREW,@ROLE)",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@CREW", crewId),
                new SqlParameter("@ROLE", role)
            );
        }

        // ========================= DELETE METHODS =========================

        /// <summary>
        /// Delete Client
        /// </summary>
        public void DeleteClient(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM CLIENT WHERE CLIENT_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Port
        /// </summary>
        public void DeletePort(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM PORT WHERE PORT_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Vessel
        /// </summary>
        public void DeleteVessel(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM VESSEL WHERE VESSEL_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Voyage
        /// </summary>
        public void DeleteVoyage(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM VOYAGE WHERE VOYAGE_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Container
        /// </summary>
        public void DeleteContainer(string serial)
        {
            ExecuteNonQuery(
                "DELETE FROM CONTAINER WHERE SERIAL_NUMBER=@SERIAL",
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Delete Crew Member
        /// </summary>
        public void DeleteCrewMember(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM CREWMEMBER WHERE CREW_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Manifest
        /// </summary>
        public void DeleteManifest(int id)
        {
            ExecuteNonQuery(
                "DELETE FROM MANIFEST WHERE MANIFEST_ID=@ID",
                new SqlParameter("@ID", id)
            );
        }

        /// <summary>
        /// Delete Carries
        /// </summary>
        public void DeleteCarries(int voyageId, string serial)
        {
            ExecuteNonQuery(
                @"DELETE FROM CARRIES
                  WHERE VOYAGE_ID=@VOYAGE
                  AND SERIAL_NUMBER=@SERIAL",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Delete Lists In
        /// </summary>
        public void DeleteListsIn(int manifestId, string serial)
        {
            ExecuteNonQuery(
                @"DELETE FROM LISTS_IN
                  WHERE MANIFEST_ID=@MANIFEST
                  AND SERIAL_NUMBER=@SERIAL",
                new SqlParameter("@MANIFEST", manifestId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Delete Has
        /// </summary>
        public void DeleteHas(int voyageId, int crewId)
        {
            ExecuteNonQuery(
                @"DELETE FROM HAS
                  WHERE VOYAGE_ID=@VOYAGE
                  AND CREW_ID=@CREW",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@CREW", crewId)
            );
        }

        // ========================= UPDATE METHODS =========================

        /// <summary>
        /// Update Client
        /// </summary>
        public void UpdateClient(int id, string newName, string newContact)
        {
            ExecuteNonQuery(
                @"UPDATE CLIENT
                  SET CLIENT_NAME=@NAME,
                      CONTACT_INFO=@CONTACT
                  WHERE CLIENT_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", newName),
                new SqlParameter("@CONTACT", newContact)
            );
        }

        /// <summary>
        /// Update Port
        /// </summary>
        public void UpdatePort(int id, string newName, decimal newFee,
                               string newCity, string newCountry)
        {
            ExecuteNonQuery(
                @"UPDATE PORT
                  SET PORT_NAME=@NAME,
                      DOCKING_FEES=@FEE,
                      CITY=@CITY,
                      COUNTRY=@COUNTRY
                  WHERE PORT_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", newName),
                new SqlParameter("@FEE", newFee),
                new SqlParameter("@CITY", newCity),
                new SqlParameter("@COUNTRY", newCountry)
            );
        }

        /// <summary>
        /// Update Vessel
        /// </summary>
        public void UpdateVessel(int id, int newCapacity,
                                 string newRegistration,
                                 decimal newFuelRating)
        {
            ExecuteNonQuery(
                @"UPDATE VESSEL
                  SET CAPACITY=@CAPACITY,
                      REGISTRATION=@REG,
                      FUEL_EFFICIENCY_RATING=@FUEL
                  WHERE VESSEL_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@CAPACITY", newCapacity),
                new SqlParameter("@REG", newRegistration),
                new SqlParameter("@FUEL", newFuelRating)
            );
        }

        /// <summary>
        /// Update Voyage
        /// </summary>
        public void UpdateVoyage(int id, string newStatus,
                                 DateTime newDeparture,
                                 DateTime newArrival)
        {
            ExecuteNonQuery(
                @"UPDATE VOYAGE
                  SET STATUS=@STATUS,
                      DEPARTURE_DATE=@DEP,
                      ARRIVAL_DATE=@ARR
                  WHERE VOYAGE_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@STATUS", newStatus),
                new SqlParameter("@DEP", newDeparture),
                new SqlParameter("@ARR", newArrival)
            );
        }

        /// <summary>
        /// Update Container
        /// </summary>
        public void UpdateContainer(string serial, string newSize,
                                    string newCargoType)
        {
            ExecuteNonQuery(
                @"UPDATE CONTAINER
                  SET SIZE=@SIZE,
                      CARGO_TYPE=@CARGO
                  WHERE SERIAL_NUMBER=@SERIAL",
                new SqlParameter("@SERIAL", serial),
                new SqlParameter("@SIZE", newSize),
                new SqlParameter("@CARGO", newCargoType)
            );
        }

        /// <summary>
        /// Update Crew Member
        /// </summary>
        public void UpdateCrewMember(int id, string newName,
                                     string newNationality)
        {
            ExecuteNonQuery(
                @"UPDATE CREWMEMBER
                  SET CREW_NAME=@NAME,
                      NATIONALITY=@NATIONALITY
                  WHERE CREW_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@NAME", newName),
                new SqlParameter("@NATIONALITY", newNationality)
            );
        }

        /// <summary>
        /// Update Manifest
        /// </summary>
        public void UpdateManifest(int id, DateTime newDate)
        {
            ExecuteNonQuery(
                @"UPDATE MANIFEST
                  SET MANIFEST_DATE=@DATE
                  WHERE MANIFEST_ID=@ID",
                new SqlParameter("@ID", id),
                new SqlParameter("@DATE", newDate)
            );
        }

        /// <summary>
        /// Update Carries
        /// </summary>
        public void UpdateCarriesRole(int voyageId, string serial)
        {
            ExecuteNonQuery(
                @"UPDATE CARRIES
                  SET SERIAL_NUMBER=@SERIAL
                  WHERE VOYAGE_ID=@VOYAGE",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Update Lists In
        /// </summary>
        public void UpdateListsIn(int manifestId, string serial)
        {
            ExecuteNonQuery(
                @"UPDATE LISTS_IN
                  SET SERIAL_NUMBER=@SERIAL
                  WHERE MANIFEST_ID=@MANIFEST",
                new SqlParameter("@MANIFEST", manifestId),
                new SqlParameter("@SERIAL", serial)
            );
        }

        /// <summary>
        /// Update Has Role
        /// </summary>
        public void UpdateHasRole(int voyageId, int crewId, string newRole)
        {
            ExecuteNonQuery(
                @"UPDATE HAS
                  SET ROLE=@ROLE
                  WHERE VOYAGE_ID=@VOYAGE
                  AND CREW_ID=@CREW",
                new SqlParameter("@VOYAGE", voyageId),
                new SqlParameter("@CREW", crewId),
                new SqlParameter("@ROLE", newRole)
            );
        }

        // ========================= SELECT ALL METHODS =========================

        public DataTable GetAllClients()
        {
            return ExecuteSelect("SELECT * FROM CLIENT");
        }

        public DataTable GetAllPorts()
        {
            return ExecuteSelect("SELECT * FROM PORT");
        }

        public DataTable GetAllVessels()
        {
            return ExecuteSelect("SELECT * FROM VESSEL");
        }

        public DataTable GetAllVoyages()
        {
            return ExecuteSelect("SELECT * FROM VOYAGE");
        }

        public DataTable GetAllContainers()
        {
            return ExecuteSelect("SELECT * FROM CONTAINER");
        }

        public DataTable GetAllCrewMembers()
        {
            return ExecuteSelect("SELECT * FROM CREWMEMBER");
        }

        public DataTable GetAllManifests()
        {
            return ExecuteSelect("SELECT * FROM MANIFEST");
        }

        public DataTable GetAllCarries()
        {
            return ExecuteSelect("SELECT * FROM CARRIES");
        }

        public DataTable GetAllListsIn()
        {
            return ExecuteSelect("SELECT * FROM LISTS_IN");
        }

        public DataTable GetAllHas()
        {
            return ExecuteSelect("SELECT * FROM HAS");
        }

        // ========================= JOIN QUERIES =========================

        public DataTable GetVoyageFullDetails()
        {
            string query =
            @"SELECT 
                V.VOYAGE_ID AS VoyageID,
                V.STATUS AS Status,
                V.DEPARTURE_DATE AS DepartureDate,
                V.ARRIVAL_DATE AS ArrivalDate,
                VE.REGISTRATION AS VesselRegistration,
                VE.CAPACITY AS Capacity,
                P1.PORT_NAME AS OriginPort,
                P2.PORT_NAME AS DestPort,
                P1.COUNTRY AS OriginCountry,
                P2.COUNTRY AS DestCountry
              FROM VOYAGE V
              INNER JOIN VESSEL VE
                ON V.VESSEL_ID = VE.VESSEL_ID
              INNER JOIN PORT P1
                ON V.ORIGIN_PORT_ID = P1.PORT_ID
              INNER JOIN PORT P2
                ON V.DEST_PORT_ID = P2.PORT_ID";

            return ExecuteSelect(query);
        }

        public DataTable GetContainersWithClientAndVoyage()
        {
            string query =
            @"SELECT
                C.SERIAL_NUMBER AS SerialNumber,
                C.CARGO_TYPE AS CargoType,
                C.SIZE AS Size,
                CL.CLIENT_NAME AS ClientName,
                V.VOYAGE_ID AS VoyageID,
                V.STATUS AS VoyageStatus
              FROM CONTAINER C
              INNER JOIN CLIENT CL
                ON C.CLIENT_ID = CL.CLIENT_ID
              LEFT JOIN CARRIES CA
                ON C.SERIAL_NUMBER = CA.SERIAL_NUMBER
              LEFT JOIN VOYAGE V
                ON CA.VOYAGE_ID = V.VOYAGE_ID";

            return ExecuteSelect(query);
        }

        public DataTable GetCrewByVoyage(int voyageId)
        {
            string query =
            @"SELECT
                C.CREW_NAME AS CrewName,
                C.NATIONALITY AS Nationality,
                H.ROLE AS Role
              FROM HAS H
              INNER JOIN CREWMEMBER C
                ON H.CREW_ID = C.CREW_ID
              WHERE H.VOYAGE_ID = @VOYAGE";

            return ExecuteSelect(query,
                new SqlParameter("@VOYAGE", voyageId));
        }

        public DataTable GetManifestWithContainers(int manifestId)
        {
            string query =
            @"SELECT
                M.MANIFEST_ID AS ManifestID,
                M.MANIFEST_DATE AS ManifestDate,
                C.SERIAL_NUMBER AS SerialNumber,
                C.CARGO_TYPE AS CargoType,
                C.SIZE AS Size,
                CL.CLIENT_NAME AS ClientName
              FROM MANIFEST M
              INNER JOIN LISTS_IN L
                ON M.MANIFEST_ID = L.MANIFEST_ID
              INNER JOIN CONTAINER C
                ON L.SERIAL_NUMBER = C.SERIAL_NUMBER
              INNER JOIN CLIENT CL
                ON C.CLIENT_ID = CL.CLIENT_ID
              WHERE M.MANIFEST_ID = @MANIFEST";

            return ExecuteSelect(query,
                new SqlParameter("@MANIFEST", manifestId));
        }

        public DataTable GetVoyagesWithContainerCount()
        {
            string query =
            @"SELECT
                V.VOYAGE_ID AS VoyageID,
                V.STATUS AS Status,
                V.DEPARTURE_DATE AS DepartureDate,
                COUNT(C.SERIAL_NUMBER) AS ContainerCount
              FROM VOYAGE V
              LEFT JOIN CARRIES C
                ON V.VOYAGE_ID = C.VOYAGE_ID
              GROUP BY
                V.VOYAGE_ID,
                V.STATUS,
                V.DEPARTURE_DATE";

            return ExecuteSelect(query);
        }

        // ========================= INQUIRIES =========================

        /// <summary>
        /// Inquiry 1
        /// </summary>
            public DataTable GetMostTransportedCargoType()
            {
                string query =
                @"SELECT TOP 1
                    C.CARGO_TYPE,
                    COUNT(*) AS ContainerCount
                FROM CONTAINER C
                INNER JOIN CARRIES CA
                    ON C.SERIAL_NUMBER = CA.SERIAL_NUMBER
                GROUP BY C.CARGO_TYPE
                ORDER BY ContainerCount DESC";

                return ExecuteSelect(query);
            }

            /// <summary>
            /// Inquiry 2
            /// </summary>
            public DataTable GetVesselsWithoutVoyagesLastMonth()
            {
                string query =
                @"SELECT
                    V.VESSEL_ID,
                    V.REGISTRATION
                  FROM VESSEL V
                  WHERE V.VESSEL_ID NOT IN
                  (
                      SELECT DISTINCT VO.VESSEL_ID
                      FROM VOYAGE VO
                      WHERE VO.DEPARTURE_DATE >= DATEADD(MONTH,-1,GETDATE())
                         OR VO.ARRIVAL_DATE >= DATEADD(MONTH,-1,GETDATE())
                  )";

                return ExecuteSelect(query);
            }

            /// <summary>
            /// Inquiry 3
            /// </summary>
            public DataTable GetTopCaptainLastMonth()
            {
                string query =
                @"SELECT TOP 1
                    C.CREW_NAME,
                    COUNT(*) AS VoyageCount
                  FROM HAS H
                  INNER JOIN CREWMEMBER C
                    ON H.CREW_ID = C.CREW_ID
                  INNER JOIN VOYAGE V
                    ON H.VOYAGE_ID = V.VOYAGE_ID
                  WHERE H.ROLE = 'Captain'
                    AND V.DEPARTURE_DATE >= DATEADD(MONTH,-1,GETDATE())
                  GROUP BY C.CREW_NAME
                  ORDER BY VoyageCount DESC";

                return ExecuteSelect(query);
            }

            /// <summary>
            /// Inquiry 4
            /// </summary>
            public DataTable GetClientsWithoutShipmentsLastMonth()
            {
                string query =
                @"SELECT
                    CL.CLIENT_ID,
                    CL.CLIENT_NAME
                  FROM CLIENT CL
                  WHERE CL.CLIENT_ID NOT IN
                  (
                      SELECT DISTINCT C.CLIENT_ID
                      FROM CONTAINER C
                      INNER JOIN CARRIES CA
                        ON C.SERIAL_NUMBER = CA.SERIAL_NUMBER
                      INNER JOIN VOYAGE V
                        ON CA.VOYAGE_ID = V.VOYAGE_ID
                      WHERE V.DEPARTURE_DATE >= DATEADD(MONTH,-1,GETDATE())
                  )";

                return ExecuteSelect(query);
            }

            /// <summary>
            /// Inquiry 5
            /// </summary>
            public DataTable GetContainersDockedAtPortsLastMonth()
            {
                string query =
                @"SELECT DISTINCT
                    P.PORT_NAME,
                    C.SERIAL_NUMBER,
                    C.CARGO_TYPE
                  FROM PORT P
                  INNER JOIN VOYAGE V
                    ON P.PORT_ID = V.DEST_PORT_ID
                  INNER JOIN CARRIES CA
                    ON V.VOYAGE_ID = CA.VOYAGE_ID
                  INNER JOIN CONTAINER C
                    ON CA.SERIAL_NUMBER = C.SERIAL_NUMBER
                  WHERE V.ARRIVAL_DATE >= DATEADD(MONTH,-1,GETDATE())
                  ORDER BY P.PORT_NAME";

                return ExecuteSelect(query);
            }

            /// <summary>
            /// Inquiry 6
            /// </summary>
            public DataTable GetVesselContainerTotalsLastMonth()
            {
                string query =
                @"SELECT
                    VE.REGISTRATION,
                    COUNT(CA.SERIAL_NUMBER) AS TotalContainers
                  FROM VESSEL VE
                  LEFT JOIN VOYAGE V
                    ON VE.VESSEL_ID = V.VESSEL_ID
                  LEFT JOIN CARRIES CA
                    ON V.VOYAGE_ID = CA.VOYAGE_ID
                  WHERE V.DEPARTURE_DATE >= DATEADD(MONTH,-1,GETDATE())
                  GROUP BY VE.REGISTRATION
                  ORDER BY TotalContainers DESC";

                return ExecuteSelect(query);
            }


        // ========================= HELPER METHODS =========================

        private void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private DataTable ExecuteSelect(string query,
                                        params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        // ========================= CONNECTION TEST =========================

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}