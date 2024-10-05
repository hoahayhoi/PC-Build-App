using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Customer;
using api.Models;

namespace api.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDto ToCustomerDto(this Customer customerModel)
        {
            return new CustomerDto
            {
                Id = customerModel.Id,
                Name = customerModel.Name,
                Email = customerModel.Email,
                Phone = customerModel.Phone,
                Address = customerModel.Address,
                Configurations = customerModel.Configurations.Select(c => c.ToConfigurationDto()).ToList(),
                Orders = customerModel.Orders.Select(o=> o.ToOrderDto()).ToList()
            };
        }

        public static Customer ToCustomerFromCreateDTO(this CreateCustomerRequestDto customerDto)
        {
            return new Customer
            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                Phone = customerDto.Phone,
                Address = customerDto.Address
            };
        }
    }
}