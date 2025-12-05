🟦 1. If you have a Dockerfile → build & run directly
Build the image

Go to the folder where the Dockerfile is:

docker build -t myapp .

Run the container
docker run -p 8080:8080 myapp


But this is only for one container.

If you have multiple components (API + database), then you want Docker Compose.

🟧 2. If you have docker-compose.yml → use Docker Compose
Start everything

In the folder with docker-compose.yml:

docker compose up

Start and rebuild

(Do this after you modify the code)

docker compose up --build

Run in background
docker compose up -d

Stop everything
docker compose down

Remove containers + volumes (clean slate)
docker compose down -v
