import express from 'express';
import bodyParser from 'body-parser';
import formRoutes from './routes/forms';

const app = express();
const port = 3000;

app.use(bodyParser.json());
app.use('/forms', formRoutes);

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
}).on('error', (error) => {
    console.error(`Error occurred while starting the server: ${error.message}`);
});