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

left to right direction
    
entity Source <<ENTITY>> #FF6500
entity Source.id <<NUMBER>> #FFBD73
entity Source.name <<TEXT>> #FFBD73
entity Source.url <<TEXT>> #FFBD73

Source.id -d-* Source 
Source.name -d-* Source 
Source.url -d-* Source


left to right direction

entity Tag <<ENTITY>> #08C2FF 
entity Tag.name <<TEXT>> #BCF2F6 
entity Tag.id <<NUMBER>> #BCF2F6

Tag.id -d-* Tag 
Tag.name -d-* Tag

@enduml


- ER-модель
- реляційна схема

