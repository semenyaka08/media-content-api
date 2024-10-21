# Проєктування бази даних

## Модель бізнес-об'єктів

@startuml

left to right direction

entity User <<ENTITY>> #900020
entity User.id <<NUMBER>> #C41E3A
entity User.first_name <<TEXT>> #C41E3A
entity User.last_name <<TEXT>> #C41E3A
entity User.email <<TEXT>> #C41E3A
entity User.password <<TEXT>> #C41E3A

User.id -d-* User
User.first_name -d-* User
User.last_name -d-* User
User.email -d-* User
User.password -d-* User

@enduml


- ER-модель
- реляційна схема

