
# BaseGovPtNet

This is a library to query the Portuguese public sector spending contracts and entities.

## Quick Start

```
await Client.GetByIdAsync<Contract>(9180146)

## Usage

await Client.GetByIdAsync<Contract>(9180146) // Returns Contract object with id: 9180146
await Client.ListAsync<ContractSummary>(1, 3)// Returns list of ContractSummary objects with pagesize:3 pagenumber:1, ascending by id

## Support

For support, email sidegence@gmail.com


## Optimizations
