import mysql from "mysql"

import { DB_HOST, DB_USER, DB_PASS, DB_NAME } from "../secrets"

export const db = mysql.createConnection({
    host: DB_HOST,
    user: DB_USER,
    password: DB_PASS,
    database: DB_NAME
})