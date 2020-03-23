# ECommerce ProductCatalog

> Business Capabilities

![business capabilzities](./docs/business-capability-diagram.png)

## Setup

## Deploy

## Service Information

```sh
 Dev Machine Url : http://localhost:5001
 Port:5001
```

![service integration](./docs/productcatalog-integration.png)

![service information](./docs/productcatalog-microservice.png)

### Endpoints

| Name            | Url        |
| --------------- | ---------- |
|                 |            |
| Product Catalog | /products/ |
| Events          | /events/   |

### Event Feed

| Name                | Description                               |
| ------------------- | ----------------------------------------- |
|                     |                                           |
| ProductCreatedEvent | happend when create new product in system |
| ProductUpdatedEvent | happend when update product's information |
| ProductDeletedEvent | happend when delete product from system   |

## Ownership of data

### Central Database Store Procedure

Product Catalog

```sh
 Name:
 Params:
 Result:
```

EventStore

```sh
 Name:
 Params:
 Result:
```

### Read-Optimizing Database Store Procedure

Product Catalog

```sh
 Name:
 Params:
 Result:
```

EventStore

```sh
 Name:
 Params:
 Result:
```

### Event Store

![storing event](./docs/productcatalog-storing-event.png)

## Locality of data

### Catching

> The purpose of caching:
>
> -   To eliminate the need, in many cases, to request information the caller already has
>
> -   To eliminate the need, in many other situations, to send full HTTP responses

![caching with http cache](./docs/productcatalog-caching-httpcache.png)

### Mirror data

> Replacing a query to another microservice with a query to the microservice’s own database by creating a `read model`: a data model that can be queried easily and efficiently.
>
> Read models are often based on **events** from other microservices.
>
> Read models can also be built from **responses to queries** to other microservices
