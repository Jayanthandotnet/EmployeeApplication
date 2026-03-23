using EmployeeApp.Models;
public static class EmployeeEndpoints
{
    public static IEndpointRouteBuilder MapEmployeeEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/employees")
                       .WithTags("Employees")
                       .WithOpenApi();
 
        // GET /api/v1/employees
        group.MapGet("/", GetEmployees)
             .WithName("GetEmployees")
             .WithSummary("List all employees")
             .WithDescription("Returns a paginated, filterable list of employees.")
             .Produces<Employee>(StatusCodes.Status200OK);        
 
        return app;
    }
 
    // ── Handler: GET /employees ─────────────────────────────────────────────
    private static async Task<IResult> GetEmployees(
        //[AsParameters] EmployeeQuery query,
        //IEmployeeService             service,
        ILogger<Program>             logger,
        CancellationToken            ct)
    {
       
 
        //var result = await service.GetEmployeesAsync(query, ct);
        return Results.Ok(new List<Employee>
    {
        new(1,  "Alice",   "Chen",      "alice.chen@acme.io",      "Engineering",   "Senior Engineer",        120_000m, new DateOnly(2019, 3, 12)),
        new(2,  "Bob",     "Martinez",  "bob.m@acme.io",           "Engineering",   "Staff Engineer",         145_000m, new DateOnly(2017, 7, 1))
    });
    }
 
    // ── Handler: GET /employees/{id} ────────────────────────────────────────
    
}