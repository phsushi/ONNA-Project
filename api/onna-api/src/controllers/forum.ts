import { Request, Response } from "express"

import { db } from "../db/connection"

// criar_Forum
export const criar_Forum = async (req:Request, res:Response) => {
    const q = "call criar_Forum(?, ?)"

    const values = [
        req.body.nome,
        req.body.descricao
    ]

    db.query(q, [...values], (err) => {
        if(err){
            return res.status(500).json(err)
        }

        return res.status(200).json(values)
    })
}
