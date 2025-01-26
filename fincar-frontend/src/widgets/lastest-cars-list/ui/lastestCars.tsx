import { useEffect } from 'react'
import styles from './lastestCars.module.css'
import { CarCard } from 'entities/car/car-card'
import { carModel } from 'entities/car'
import { observer } from 'mobx-react-lite'
import { SkeletonContainer } from 'shared/ui/skeleton-container'

export const LastestCars = observer(() =>{
    const { store: { getCarListLimited, carListError, carListLimited, isLoading  } } 
    = carModel
    
    useEffect(() => {
        getCarListLimited(10);
    }, [])

    if (carListError) {
        return<>{carListError}</>
    }
    
    return (
        <div className={styles.wrapper}>
            <div className={styles.titleContainer}>
                <h5>Lastest Cars</h5>
            </div>
            <div className={styles.listContainer}>


                {isLoading ? ( 
                    <SkeletonContainer defaultCount={3} />
                ) : ( 
                carListLimited.map((car)=>(
                    <CarCard
                        key={car.id}
                        id={car.id}
                        brandName={car.brandName}
                        name={car.name}
                        engine={car.engine}
                        year={car.year}
                        mileage={car.mileage}
                        price={car.price}
                        image={car.images[0]}
                    />
                )))}
                
            </div>
        </div>
    )
})