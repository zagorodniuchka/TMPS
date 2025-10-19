# Laboratory Work #2 – Creational Design Patterns

**Author:** Zagorodnyuk Anastasia  
**Group:** FAF-223  
**Course:** Design Patterns & Software Systems Design

## Project Description
This project implements a **Logistics Transport Management System** using **three Creational Design Patterns**: Factory Method, Prototype, and Singleton.  
The system can create different transport types (trucks, drones, ships), clone existing ones, and keep them in a global registry.

---

##  Patterns Used
### 1 Factory Method
- **Purpose:** Creates transport objects depending on their type.
- **Implementation:** Separate factories for each type (Truck, Drone, Ship).
- **Benefit:** Adds new transport types easily.

### 2 Prototype
- **Purpose:** Clones existing transport instances.
- **Implementation:** `TransportPrototypeImpl` wraps a base transport and duplicates it.
- **Benefit:** Efficient reuse of configured transports.

### 3 Singleton
- **Purpose:** Global registry for all transports.
- **Implementation:** `TransportRegistry` ensures only one instance exists.
- **Benefit:** Centralized access and consistency.

---

##  Output Example

=== Logistics Transport System ===

Created using Factory:

Truck [TRK001] - Capacity: 10000kg, Speed: 90km/h, Status: Available

Drone [DRN001] - Capacity: 50kg, Speed: 120km/h, Status: Available

Ship [SHP001] - Capacity: 500000kg, Speed: 40km/h, Status: Available

Cloned using Prototype: Drone [31b034] - Capacity: 50kg, Speed: 120km/h, Status: Available

Registered transports:
- TRK001
- DRN001
- SHP001
- 31b034

Singleton check (same instance): True
