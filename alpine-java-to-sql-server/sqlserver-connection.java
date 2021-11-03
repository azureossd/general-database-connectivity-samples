	import java.sql.Connection;
	import java.sql.DriverManager;
	import java.sql.ResultSet;
	import java.sql.SQLException;
	import java.sql.Statement;
	
	class SQLDatabaseConnection {
	
	    public static void main(String[] args) {
	        String connectionUrl =
	                "jdbc:sqlserver://<SQLServer>.database.windows.net:1433;"
	                + "database=<DatabaseName>;"
	                + "user=<user>@<DatabaseName>;"
	                + "password=<Password>;"
	                + "encrypt=true;"
	                + "trustServerCertificate=false;"
	                + "loginTimeout=30;";
	
	        ResultSet resultSet = null;
	
	        try (Connection connection = DriverManager.getConnection(connectionUrl);
	                Statement statement = connection.createStatement();) {
	
	            String selectSql = "SELECT * FROM EMPLOYEE";
	            resultSet = statement.executeQuery(selectSql);
	
	            while (resultSet.next()) {
	                System.out.println(resultSet.getString(2) + " " + resultSet.getString(3));
	            }
	        }
	        catch (SQLException e) {
	            e.printStackTrace();
	        }
	    }
	}
