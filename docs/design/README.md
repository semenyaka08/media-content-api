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


entity MediaContent <<ENTITY>>
entity MediaContent.id <<NUMBER>>

MediaContent.id -d-* MediaContent


entity Role <<ENTITY>>
entity Role.id <<NUMBER>>

Role.id -l-* Role


entity Permission <<ENTITY>>
entity Permission.id <<NUMBER>>

Permission.id -l-* Permission


entity Source <<ENTITY>> #FF6500
entity Source.id <<NUMBER>> #FFBD73
entity Source.name <<TEXT>> #FFBD73
entity Source.url <<TEXT>> #FFBD73

Source.id -d-* Source 
Source.name -r-* Source 
Source.url -u-* Source


entity AnalysisResult <<ENTITY>> #80FF00
entity AnalysisResult.id <<NUMBER>> #B2FF66
entity AnalysisResult.created_at <<DATE>> #B2FF66
entity AnalysisResult.title <<TEXT>> #B2FF66
entity AnalysisResult.description <<TEXT>> #B2FF66
entity AnalysisResult.body <<TEXT>> #B2FF66

AnalysisResult.id -u-* AnalysisResult
AnalysisResult.created_at -u-* AnalysisResult
AnalysisResult.title -u-* AnalysisResult
AnalysisResult.description -u-* AnalysisResult
AnalysisResult.body -u-* AnalysisResult


entity Tag <<ENTITY>> #08C2FF 
entity Tag.name <<TEXT>> #BCF2F6 
entity Tag.id <<NUMBER>> #BCF2F6

Tag.id -u-* Tag 
Tag.name -u-* Tag

User -- MediaContent
User -- AnalysisResult
User -- Role
Role -- Permission
MediaContent -- Source
MediaContent -- AnalysisResult
MediaContent -- Tag
AnalysisResult -- Tag
Source -- Tag

@enduml


- ER-модель
- реляційна схема

