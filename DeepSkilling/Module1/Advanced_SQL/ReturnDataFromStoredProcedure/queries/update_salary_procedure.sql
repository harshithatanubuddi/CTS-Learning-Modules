CREATE PROCEDURE sp_UpdateEmployeeSalary
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = @Salary
    WHERE EmployeeID = @EmployeeID;
END;