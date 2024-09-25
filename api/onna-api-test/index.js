const express = require('express');
const { PrismaClient } = require('@prisma/client');
const prisma = new PrismaClient();
const app = express();

app.use(express.json());

// Create
app.post('/users', async (req, res) => {
    const { name, email } = req.body;
    try {
        const user = await prisma.user.create({
            data: {
                name,
                email,
            },
        });
        res.status(201).json(user);
    } catch (error) {
        res.status(400).json({ error: 'Email já existe' });
    }
});

// Read
app.get('/users', async (req, res) => {
    const users = await prisma.user.findMany();
    res.json(users);
});

// Read id
app.get('/users/:id', async (req, res) => {
    const { id } = req.params;
    const user = await prisma.user.findUnique({
        where: { id: parseInt(id) },
    });
    if (user) {
        res.json(user);
    } else {
        res.status(404).json({ error: 'Usuário não encontrado' });
    }
});

// Update
app.put('/users/:id', async (req, res) => {
    const { id } = req.params;
    const { name, email } = req.body;
    try {
        const user = await prisma.user.update({
            where: { id: parseInt(id) },
            data: {
                name,
                email,
            },
        });
        res.json(user);
    } catch (error) {
        res.status(400).json({ error: 'Não foi possível atualizar o usuário' });
    }
});

// Delete 
app.delete('/users/:id', async (req, res) => {
    const { id } = req.params;
    try {
        await prisma.user.delete({
            where: { id: parseInt(id) },
        });
        res.status(204).send();
    } catch (error) {
        res.status(400).json({ error: 'Não foi possível excluir o usuário' });
    }
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () =>
  console.log(`O servidor está rodando na porta ${PORT}`)
);