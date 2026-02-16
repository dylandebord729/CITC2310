//Numbers 1-3
    //No Code
//Number 4
    public DbSet<Customer> Customers { get; set; } = null;
//Number 5
    //No Code
//Number 6
builder.services.AddDbContext<CustomerContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Customer")));
//Numbers 7-9
    //No Code
//Number 10
builder.services.AddRouting(options => {
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});