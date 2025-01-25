import { LastestCars } from "widgets/lastest-cars-list"
import styles from './home.module.css'

export const Home = () => {
    return (
        <div className={styles.wrapper}>
            <LastestCars />
        </div>
    )
}