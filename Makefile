DOTNET_EF=dotnet ef
DOTNET=dotnet
DATABASE_PROJECT=Wiky.Repository

### Database
install-db: db-migrate

db-diff: ## Create database migration. Needs $NAME variable for migration name
	$(DOTNET_EF) migrations add --project=$(DATABASE_PROJECT) $(NAME)

db-migrate: ## Update database with current migrations not processed
	$(DOTNET_EF) database update --project=$(DATABASE_PROJECT)

.PHONY: install-db db-diff db-migrate