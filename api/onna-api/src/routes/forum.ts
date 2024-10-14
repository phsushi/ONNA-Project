import { Router } from "express"

import { criar_Forum } from "../controllers/forum"

const forumRoutes:Router = Router()

forumRoutes.post("/forum", criar_Forum)

export default forumRoutes
