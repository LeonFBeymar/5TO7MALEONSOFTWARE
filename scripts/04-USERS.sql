CREATE USER IF NOT EXISTS "Adminitrador"@"%" IDENTIFIED BY "passwordAdministrador";
CREATE USER IF NOT EXISTS "PM"@"10.3.45.%" IDENTIFIED BY "passwordPM";
CREATE USER IF NOT EXISTS "EmpleadoE"@"10.3.45.%" IDENTIFIED BY "passwordE";

GRANT SELECT ON softwarefactory.* TO "Adminitrador"@"%";
GRANT INSERT,UPDATE ON softwarefactory.proyecto TO "Adminitrador"@"%";
GRANT INSERT ON softwarefactory.tecnologia TO "Adminitrador"@"%";
GRANT INSERT ON softwarefactory.cliente TO "Adminitrador"@"%";
GRANT INSERT ON softwarefactory.empleado TO "Adminitrador"@"%";

GRANT SELECT ON softwarefactory.* TO "PM"@"10.3.45.%";
GRANT INSERT, UPDATE(calificacion) ON softwarefactory.experiencia TO "PM"@"10.3.45.%";
GRANT INSERT ON softwarefactory.empleado TO "PM"@"10.3.45.%";
GRANT INSERT ON softwarefactory.requerimiento TO "PM"@"10.3.45.%";
GRANT INSERT,UPDATE(fin) ON softwarefactory.tarea TO "PM"@"10.3.45.%";

GRANT SELECT ON softwarefactory.* TO "EmpleadoE"@"10.3.45.%";

