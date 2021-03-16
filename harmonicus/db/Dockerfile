FROM mysql:5.7.22
EXPOSE 3306
COPY ./harmonicus/db/migrations/ /home/database/
COPY ./harmonicus/db/dataset/ /home/database/
COPY ./harmonicus/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh