﻿using ClientConnect.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientConnect.Infrastructure.Data;

public class ClientConnectContext : DbContext
{
    public ClientConnectContext(DbContextOptions<ClientConnectContext> opts) : base(opts)
    {

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Interaction> Interactions { get; set; }

}