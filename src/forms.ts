import { Router } from 'express';

const router = Router();

// In-memory storage for forms and responses
const forms: any[] = [];
const responses: any[] = [];

// Create a new form
router.post('/', (req, res) => {
    const form = req.body;
    forms.push(form);
    res.status(201).send(form);
});

// Get all forms
router.get('/', (req, res) => {
    res.send(forms);
});

// Submit a response
router.post('/:formId/responses', (req, res) => {
    const formId = req.params.formId;
    const response = req.body;
    responses.push({ formId, response });
    res.status(201).send(response);
});

// Get responses for a form
router.get('/:formId/responses', (req, res) => {
    const formId = req.params.formId;
    const formResponses = responses.filter(r => r.formId === formId);
    res.send(formResponses);
});

export default router;
