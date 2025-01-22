import { CarListPage } from "pages/car-list-page";
import { createBrowserRouter } from "react-router-dom";
import { MainLayout } from "shared/ui/main-layout";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <MainLayout/>,
        children: [
            {
                index: true,
                element: <CarListPage/>
            },
            {
                path: ":id",
                element: <>car detail</>
            }
        ]
    }
])